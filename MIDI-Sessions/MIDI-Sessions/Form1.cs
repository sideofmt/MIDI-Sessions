using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using Midi;
using MIDI_Sessions.MIDI;
using MIDI_Sessions.Communication;
using System.Security.Permissions;

namespace MIDI_Sessions{
    public partial class Form1 : Form, BaseAdapter {
        private const int pitch = 12;                   //ピッチ。音の高さを変更する際に使用。
        private const int MAXPLAYER = 4;                //ユーザ数の上限。

        private IPlayMidi play;                         //PlayMidiのインターフェース。これを用いてMidiの再生、停止を行う。
        private Channel cha;                            //Midiのチャンネル。ユーザ毎にチャンネルが割り振られる。
        private int velocity;                           //velocity。ツマミを操作することによって値を変化させることができる。
        private Instrument inst;
        private Instrument preInst;
        private Dictionary<Keys, MIDIData> soundKey;    //キーの値と出力する音を関連付けるためのDictionary。
        private Keys[] qwertyKey;                       //Keysの配列。
        private OutputDevice outputDevice;              //アウトプットデバイス。
        private MIDIData sendMidiData;
        private List<MIDIData> BePlayedMidiData;
        private string IPv4;
        private int[] time;

        public Form1(){
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Form1_KeyDown);
            this.KeyUp += new KeyEventHandler(Form1_KeyUp);
            this.VelocityBar.MouseUp += new MouseEventHandler(VelocityBar_MouseUp);
            this.number1.KeyPress += new KeyPressEventHandler(Number_KeyPress);
            this.number2.KeyPress += new KeyPressEventHandler(Number_KeyPress);
            this.number3.KeyPress += new KeyPressEventHandler(Number_KeyPress);
            this.number4.KeyPress += new KeyPressEventHandler(Number_KeyPress);
            cha = Channel.Channel1;                     //Midiチャンネルの割り当て。
            velocity = 100;                             //velocityの初期値は100。
            inst = Instrument.AcousticGrandPiano;
            preInst = inst;
            IPv4 = "";
            this.VelocityBar.Value = velocity;
            openDevice();                               //outputDeviceをOpenさせる。
            soundKey = new Dictionary<Keys, MIDIData>();
            time = new int[3];
            isConnect = false;  // 通信をしているかどうか
            BePlayedMidiData = new List<MIDIData>();

            /*ドの音から1オクターブ上のドの音までを、以下の配列のように割り当てる。基本的にピアノの鍵盤と同じ位置。*/
            qwertyKey = new Keys[] { Keys.A, Keys.W, Keys.S, Keys.E, Keys.D, Keys.F, Keys.T, Keys.G, Keys.Y, Keys.H, Keys.U, Keys.J, Keys.K };

            for (int i = 0; i <= (int)Instrument.Gunshot; i++) {
                this.InstList.Items.Add((i + 1).ToString() + ". " + (Instrument.AcousticGrandPiano + i).ToString());
            }

            /*このfor文内でキーの値と出力する音を関連付けている。*/
            for (int i = 0; i < qwertyKey.Length; i++) {
                soundKey.Add(qwertyKey[i], new MIDIData(cha, Pitch.C3 + i, velocity, false, inst, preInst, time));
            }

            for (int i = 2; i <= MAXPLAYER;i++ ) {
                NumberOfPerson.Items.Add(i);
            }
            this.NumberOfPerson.SelectedIndex = 0; 
        }

        /// <summary>
        /// outputDeviceをOpenする。
        /// </summary>
        private void openDevice() {
            outputDevice = SessionUtil.ChooseOutpuDevice(); //OutputDeviceを選択。

            /* outputDeviceがOpenしていない場合は以下のfor文の内容を実行 */
            if (!outputDevice.IsOpen) {
                /* outputDeviceがない場合 */
                if (outputDevice == null) {
                    return;         //そのままreturnで終了。
                }
                outputDevice.Open();//outputDeviceをOpenする。
            }
            return;
        }

        /// <summary>
        /// 受け取ったMIDIDataを再生する。
        /// </summary>
        /// <param name="midiData"></param>
        private void playMidi() {
            lock (BePlayedMidiData) {
                foreach (MIDIData midi in BePlayedMidiData) {
                    //i++;
                    if (midi.IsPushing) {
                        play = new PlayMidi(midi, outputDevice);
                        play.Run();
                    } else {
                        play = new PlayMidi(midi, outputDevice);
                        play.Stop();
                    }
                }
                BePlayedMidiData.Clear();
            }
            return;
        }
        
        /// <summary>
        /// 何らかのキーが押された時の処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_KeyDown(object sender, KeyEventArgs e) {
            /* soundKeyでMIDIDataに関連付けられたキーが入力された場合の処理 */
            if(soundKey.ContainsKey(e.KeyCode)){
                /* キーが押しっぱなし、またはPitchの値が範囲外の場合 */
                if (soundKey[e.KeyCode].IsPushing || soundKey[e.KeyCode].Pit > Pitch.G9 || soundKey[e.KeyCode].Pit < Pitch.CNeg1) return;   //そのままreturnで終了
                
                soundKey[e.KeyCode].IsPushing = true;   //キーが押されている状態であることを示すIsPushingをtrueにする。
                time[0] = DateTime.Now.Millisecond;
                time[1] = DateTime.Now.Second;
                time[2] = DateTime.Now.Minute;
                sendMidiData = soundKey[e.KeyCode];
                BePlayedMidiData.Add(soundKey[e.KeyCode]);
            }
            return;
        }

        /// <summary>
        /// 何らかのキーが離された時の処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_KeyUp(object sender, KeyEventArgs e) {
            /* soundKeyでMIDIDataに関連付けられたキーが離された場合の処理 */
            if(soundKey.ContainsKey(e.KeyCode)){
                /* Pitchの値が範囲外の場合 */
                if (soundKey[e.KeyCode].Pit > Pitch.G9 || soundKey[e.KeyCode].Pit < Pitch.CNeg1) return;    //そのままreturnで終了

                soundKey[e.KeyCode].IsPushing = false;  //キーが押されている状態であることを示すIsPushingをfalseにする。
                time[0] = DateTime.Now.Millisecond;
                time[1] = DateTime.Now.Second;
                time[2] = DateTime.Now.Minute;
                sendMidiData = soundKey[e.KeyCode];
                BePlayedMidiData.Add(soundKey[e.KeyCode]);
            }else{
                /* 方向キーの左右どちらかが離された場合の処理 */
                for (int i = 0; i < qwertyKey.Length;i++ ) {
                    if (soundKey[qwertyKey[i]].IsPushing) return;
                }
                switch (e.KeyCode) {
                    case Keys.Right:
                        /* 右の場合 */
                        for (int i = 0; i < qwertyKey.Length; i++) {
                            if (soundKey[qwertyKey[qwertyKey.Length - 1]].Pit >= Pitch.G9) return;  //Pitchの上限を上回る場合はreturnで終了。
                            soundKey[qwertyKey[i]].Pit += pitch;    //ピッチを1オクターブ高くする。
                        }
                        break;
                    case Keys.Left:
                        /* 左の場合 */
                        for (int i = 0; i < qwertyKey.Length; i++) {
                            if (soundKey[qwertyKey[0]].Pit <= Pitch.CNeg1) return;  //Pitchの下限を下回る場合はreturnで終了。
                            soundKey[qwertyKey[i]].Pit -= pitch;    //ピッチを1オクターブ低くする。
                        }
                        break;
                    //case Keys.Up:
                    //    /* 上の場合 */
                    //    if (inst <= Instrument.AcousticGrandPiano) inst = Instrument.Gunshot;  //Instrumentが0番のPiano場合、127番のGunshotにする。
                    //    else inst--;    //それ以外の場合は一つ下の番号のInstrumentに変更する。
                    //    instChange(inst);
                    //    break;
                    //case Keys.Down:
                    //    /* 下の場合 */
                    //    if (inst >= Instrument.Gunshot) inst = Instrument.AcousticGrandPiano;  //Instrumentが127番のGunshot場合、0番のAcousticGrandPianoにする。
                    //    else inst++;    //それ以外の場合は一つ上の番号のInstrumentに変更する。
                    //    instChange(inst);
                    //    break;
                    default:
                        return;
                }
            }
            return;
        }

        private void PlayMidi_Click(object sender, EventArgs e) {

        }

        /// <summary>
        /// VelocityBarをスクロールした際に呼び出されるメソッド。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void VelocityBar_Scroll(object sender, EventArgs e) {
            velocity = VelocityBar.Value;
            this.VelocityLabel2.Text = velocity.ToString();
            return;
        }

        /// <summary>
        /// VelocityBarのマウスクリック状態が解除された際に呼び出されるメソッド。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void VelocityBar_MouseUp(object sender, EventArgs e) {
            for (int i = 0; i < qwertyKey.Length; i++) {
                soundKey[qwertyKey[i]].Velocity = velocity;
            }
            return;
        }

        /// <summary>
        /// 終了時の処理
        /// </summary>
        /// <param name="m"></param>
        protected override void WndProc(ref System.Windows.Forms.Message m) {
            const int WM_SYSCOMMAND = 0x112;
            const long SC_CLOSE = 0xF060L;

            if (m.Msg == WM_SYSCOMMAND &&
                (m.WParam.ToInt64() & 0xFFF0L) == SC_CLOSE) {
                bool exit = ApplicationExit();
                if (exit) {
                    outputDevice.Close();   //outputDeviceをCloseする。
                    if(udp != null)endConnection();        //Connectionを切断する。
                    this.Close();
                }
                return;
            }

            base.WndProc(ref m);
        }

        /// <summary>
        /// 終了確認のメッセージボックスを表示
        /// </summary>
        /// <returns></returns>
        private bool ApplicationExit() {
            //メッセージボックスを表示する
            DialogResult result = MessageBox.Show("終了しますか？",
                "終了確認",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Exclamation);

            //何が選択されたか調べる
            if (result == DialogResult.Yes) {
                //「はい」が選択された時
                return true;
            } else if (result == DialogResult.No) {
                //「いいえ」が選択された時
                return false;
            }

            return false;
        }

        /// <summary>
        /// Instrumentのリスト内の項目を選択した際に呼び出されるメソッド。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InstList_SelectedIndexChanged(object sender, EventArgs e) {
            preInst = inst;
            string instString = this.InstList.SelectedItem.ToString();
            string dot = ".";
            int foundIndex = instString.LastIndexOf(dot);
            instString = instString.Substring(0, foundIndex);
            inst = (Instrument)(int.Parse(instString) - 1);
            instChange(inst);

            return;
        }

        /// <summary>
        /// 各キーのInstrumentを変更する際に呼び出されるメソッド。
        /// </summary>
        /// <param name="inst"></param>
        private void instChange(Instrument inst) {
            for (int i = 0; i < qwertyKey.Length; i++) {
                soundKey[qwertyKey[i]].Inst = inst;    //各鍵盤のInstrumentを変更する。
            }

            return;
        }

        /// <summary>
        /// "Connect"ボタンをクリックした際に呼び出されるメソッド。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ConnectButton_Click(object sender, EventArgs e) {
            this.MemberList.Items.Clear();
            if(radioServerButton.Checked){
                // ホスト名を取得する
                string hostname = Dns.GetHostName();

                // ホスト名からIPアドレスを取得する
                IPAddress[] adrList = Dns.GetHostAddresses(hostname);
                foreach (IPAddress address in adrList) {
                    if (address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork) {
                        this.MemberList.Items.Add(address);
                        return;
                    }
                }
            }
            else if(radioClientButton.Checked){
                if (this.number1.Text.Length <= 0 || this.number2.Text.Length <= 0 || this.number3.Text.Length <= 0 || this.number4.Text.Length <= 0) {
                    MessageBox.Show("IPアドレスが入力されていません。", "注意", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return; //空白の欄が一つ以上ある場合はreturnで終了。
                }
                IPv4 = this.number1.Text + "." + this.number2.Text + "." + this.number3.Text + "." + this.number4.Text;
            } 
            else {
                IPv4 = "localhost";
            }
            this.number1.Clear();
            this.number2.Clear();
            this.number3.Clear();
            this.number4.Clear();

            startConnection();

            return;
        }

        /// <summary>
        /// IPアドレスを入力した際に呼び出されるメソッド。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Number_KeyPress(object sender, KeyPressEventArgs e) {
            if(!Char.IsDigit(e.KeyChar) && !e.KeyChar.Equals('\b')) {   //数字、又はバックスペース以外が入力された場合
                e.Handled = true;   //入力を中止する。
            }
            return;
        }

        /// <summary>
        /// 通信を切断するボタンが押された際に呼び出されるメソッド。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DisconnectButton_Click(object sender, EventArgs e) {
            if (udp == null) {
                MessageBox.Show("通信をしていません。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (MessageBox.Show("通信を終了しますか？", "通信の終了", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.Cancel) {
                // Cancelが押された時
                return;
            }

            endConnection();
            this.MemberList.Items.Clear();
            MessageBox.Show("通信を終了しました。", "通知", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void radioServerButton_CheckedChanged(object sender, EventArgs e) {
            this.number1.Enabled = false;
            this.number2.Enabled = false;
            this.number3.Enabled = false;
            this.number4.Enabled = false;
        }

        private void radioClientButton_CheckedChanged(object sender, EventArgs e) {
            this.number1.Enabled = true;
            this.number2.Enabled = true;
            this.number3.Enabled = true;
            this.number4.Enabled = true;
        }

        private void radioLocalhost_CheckedChanged(object sender, EventArgs e) {
            this.number1.Enabled = false;
            this.number2.Enabled = false;
            this.number3.Enabled = false;
            this.number4.Enabled = false;
        }

        private void MemberList_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void NumberOfPerson_SelectedIndexChanged(object sender, EventArgs e) {

        }

        // -------------------------------------
        // ここから先が通信部（非同期動作）
        // -------------------------------------

        private int sendPort;
        private int recievePort;
        private Communication.UdpCommunication udp;
        private bool isConnect;

        /// <summary>
        /// UDP通信の設定をして通信を開始します
        /// </summary>
        private void startConnection() {
            // 使用ポートの設定
            sendPort = 8000;
            recievePort = 8000;

            // MIDIDataをnullに
            sendMidiData = null;

            udp = new UdpCommunication(this, IPv4, sendPort, recievePort);

            // UPD通信を開始
            Console.WriteLine("通信を開始します");
            udp.open();
            isConnect = true;

        }

        private void endConnection() {
            Console.WriteLine("通信を終了します");
            udp.close();
            isConnect = false;
        }

        /// <summary>
        /// MIDIDataを受け取った時に呼び出される処理。
        /// </summary>
        /// <param name="mididata"></param>
        void BaseAdapter.recievedProcess(MIDIData mididata) {
            Console.WriteLine("recievedProcessが呼ばれました");
            lock (BePlayedMidiData) {
                this.BePlayedMidiData.Add(mididata);
            }
        }

        /// <summary>
        /// Timerで設定した間隔で処理を行います
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e) {
            if (isConnect) {
                if (udp == null) {
                    MessageBox.Show("通信を行えません。", "エラー", MessageBoxButtons.OK);
                    // Timerを終了
                    isConnect = false;
                    return;
                }
                if (sendMidiData != null) {
                    udp.send(sendMidiData);
                    sendMidiData = null;
                    Console.WriteLine("MIDIデータを送信しました");
                }
            }
            // MIDIデータの演奏
            playMidi();
        }

        //End Form1
    }
}
