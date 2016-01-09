using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Midi;
using MIDI_Sessions.MIDI;
using System.Security.Permissions;

namespace MIDI_Sessions{
    public partial class Form1 : Form{
        private IPlayMidi play;                         //PlayMidiのインターフェース。これを用いてMidiの再生、停止を行う。
        private Channel cha;                            //Midiのチャンネル。ユーザ毎にチャンネルが割り振られる。
        private int velocity;                           //velocity。ツマミを操作することによって値を変化させることができる。
        private Instrument inst;
        private Instrument preInst;
        private const int pitch = 12;                   //ピッチ。音の高さを変更する際に使用。
        private Dictionary<Keys, MIDIData> soundKey;    //キーの値と出力する音を関連付けるためのDictionary。
        private Keys[] qwertyKey;                       //Keysの配列。
        private OutputDevice outputDevice;              //アウトプットデバイス。
        private string IPv4;

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

            /*ドの音から1オクターブ上のドの音までを、以下の配列のように割り当てる。基本的にピアノの鍵盤と同じ位置。*/
            qwertyKey = new Keys[] { Keys.A, Keys.W, Keys.S, Keys.E, Keys.D, Keys.F, Keys.T, Keys.G, Keys.Y, Keys.H, Keys.U, Keys.J, Keys.K };

            for (int i = 0; i <= (int)Instrument.Gunshot; i++) {
                this.InstList.Items.Add((i + 1).ToString() + ". " + (Instrument.AcousticGrandPiano + i).ToString());
            }

            /*このfor文内でキーの値と出力する音を関連付けている。*/
            for (int i = 0; i < qwertyKey.Length; i++) {
                soundKey.Add(qwertyKey[i], new MIDIData(cha, Pitch.C3 + i, velocity, false, inst));
            }
        }

        /*-- outputDeviceをOpenする --*/
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
        
        /*-- 何らかのキーが押された時の処理 --*/
        private void Form1_KeyDown(object sender, KeyEventArgs e) {
            /* soundKeyでMIDIDataに関連付けられたキーが入力された場合の処理 */
            if(soundKey.ContainsKey(e.KeyCode)){
                /* キーが押しっぱなし、またはPitchの値が範囲外の場合 */
                if (soundKey[e.KeyCode].IsPushing || soundKey[e.KeyCode].Pit > Pitch.G9 || soundKey[e.KeyCode].Pit < Pitch.CNeg1) return;   //そのままreturnで終了
                
                soundKey[e.KeyCode].IsPushing = true;   //キーが押されている状態であることを示すIsPushingをtrueにする。
                play = new PlayMidi(soundKey[e.KeyCode], preInst, outputDevice);
                play.Run(); //音の再生。
            }
            return;
        }

        /*-- 何らかのキーが離された時の処理 --*/
        private void Form1_KeyUp(object sender, KeyEventArgs e) {
            /* soundKeyでMIDIDataに関連付けられたキーが離された場合の処理 */
            if(soundKey.ContainsKey(e.KeyCode)){
                /* Pitchの値が範囲外の場合 */
                if (soundKey[e.KeyCode].Pit > Pitch.G9 || soundKey[e.KeyCode].Pit < Pitch.CNeg1) return;    //そのままreturnで終了

                soundKey[e.KeyCode].IsPushing = false;  //キーが押されている状態であることを示すIsPushingをfalseにする。
                play = new PlayMidi(soundKey[e.KeyCode], preInst, outputDevice);
                play.Stop();    //音の停止。
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

        private void VelocityBar_Scroll(object sender, EventArgs e) {
            velocity = VelocityBar.Value;
            this.VelocityLabel2.Text = velocity.ToString();
        }

        private void VelocityBar_MouseUp(object sender, EventArgs e) {
            for (int i = 0; i < qwertyKey.Length; i++) {
                soundKey[qwertyKey[i]].Velocity = velocity;
            }
        }

        /*-- 終了時の処理 --*/
        protected override void WndProc(ref System.Windows.Forms.Message m) {
            const int WM_SYSCOMMAND = 0x112;
            const long SC_CLOSE = 0xF060L;

            if (m.Msg == WM_SYSCOMMAND &&
                (m.WParam.ToInt64() & 0xFFF0L) == SC_CLOSE) {
                bool exit = ApplicationExit();
                if (exit) {
                    outputDevice.Close();   //outputDeviceをCloseする。
                    this.Close();
                }
                return;
            }

            base.WndProc(ref m);
        }

        /*-- 終了確認のメッセージボックスを表示 --*/
        private bool ApplicationExit() {
            //メッセージボックスを表示する
            DialogResult result = MessageBox.Show("終了しますか？",
                "終了確認",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button2);

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

        private void instChange(Instrument inst) {
            for (int i = 0; i < qwertyKey.Length; i++) {
                soundKey[qwertyKey[i]].Inst = inst;    //各鍵盤のInstrumentを変更する。
            }

            return;
        }

        private void ConnectButton_Click(object sender, EventArgs e) {
            IPv4 = this.number1.Text + "." + this.number2.Text + "." + this.number3.Text + "." + this.number4.Text;
            Console.WriteLine(IPv4);
            this.number1.Clear();
            this.number2.Clear();
            this.number3.Clear();
            this.number4.Clear();

            return;
        }

        private void ConnectLocalhost_Click(object sender, EventArgs e) {
            IPv4 = "localhost";
            Console.WriteLine(IPv4);

            return;
        }

        private void Number_KeyPress(object sender, KeyPressEventArgs e) {
            if(!Char.IsDigit(e.KeyChar) && !e.KeyChar.Equals('\b')) {
                e.Handled = true;
            }
        }

        //End Form1
    }
}
