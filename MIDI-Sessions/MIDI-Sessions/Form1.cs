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

namespace MIDI_Sessions{
    public partial class Form1 : Form{
        private IPlayMidi play;                         //PlayMidiのインターフェース。これを用いてMidiの再生、停止を行う。
        private Channel cha;                            //Midiのチャンネル。ユーザ毎にチャンネルが割り振られる。
        private int velocity;                           //velocity。ツマミを操作することによって値を変化させることができる。
        private const int pitch = 12;                   //ピッチ。音の高さを変更する際に使用。
        private Dictionary<Keys, MIDIData> soundKey;    //キーの値と出力する音を関連付けるためのDictionary。
        private Keys[] qwertyKey;                       //Keysの配列。
        private OutputDevice outputDevice;              //アウトプットデバイス。

        public Form1(){
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Form1_KeyDown);
            this.KeyUp += new KeyEventHandler(Form1_KeyUp);
            this.FormClosing += new FormClosingEventHandler(Form1_FormClosing);     //終了する際に処理をこなうために実装。
            this.VelocityBar.MouseUp += new MouseEventHandler(VelocityBar_MouseUp);
            cha = Channel.Channel1;                     //Midiチャンネルの割り当て。
            velocity = 100;                             //velocityの初期値は100。
            this.VelocityBar.Value = velocity;
            openDevice();                               //outputDeviceをOpenさせる。 
            soundKey = new Dictionary<Keys, MIDIData>();
            VelocityLabel2.Update();

            /*ドの音から1オクターブ上のドの音までを、以下の配列のように割り当てる。基本的にピアノの鍵盤と同じ位置。*/
            qwertyKey = new Keys[] { Keys.A, Keys.W, Keys.S, Keys.E, Keys.D, Keys.F, Keys.T, Keys.G, Keys.Y, Keys.H, Keys.U, Keys.J, Keys.K };

            /*このfor文内でキーの値と出力する音を関連付けている。*/
            for (int i = 0; i < qwertyKey.Length; i++) {
                soundKey.Add(qwertyKey[i], new MIDIData(cha, Pitch.C3 + i, velocity, false));
            }
        }

        /*-- 終了時の処理 --*/
        private void Form1_FormClosing(Object sender, FormClosingEventArgs e) {
            outputDevice.Close();   //outputDeviceをCloseする。
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
                play = new PlayMidi(soundKey[e.KeyCode], outputDevice); 
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
                play = new PlayMidi(soundKey[e.KeyCode], outputDevice);
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

        //End Form1
    }
}
