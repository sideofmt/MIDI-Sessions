using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Midi;

namespace MIDI_Sessions.MIDI{
    [Serializable()]    
    class MIDIData{
        //演奏している際に他ユーザに送るMidiのデータを含むクラス。

        private Channel cha;    //MIDIチャンネル。基本的にユーザ1人に対して1つのチャンネルが与えられる。
        private Pitch pit;      //音高。
        private int velocity;   //ベロシティ。音の強さ。
        private Instrument inst;//インスト。
        private Instrument preInst;
        private bool isPushing; //キーボードが押されているかを判断。押されている場合はTrue。
        private int[] now;      //キーボードが押された、離された時の時間。[0]:ミリ秒 [1]:秒　[2]:分

        public MIDIData(Channel cha, Pitch pit, int velocity, bool isPushing, Instrument inst, Instrument preInst, int[] now) {
            this.cha = cha;
            this.pit = pit;
            this.velocity = velocity;
            this.isPushing = isPushing;
            this.inst = inst;
            this.preInst = preInst;
            this.now = now;
        }

        /**------ 以下はgetterとsetter ------**/

        public Channel Cha {
            set { this.cha = value; }
            get { return this.cha; }
        }

        public Pitch Pit {
            set { this.pit = value; }
            get { return this.pit; }
        }

        public int Velocity {
            set { this.velocity = value; }
            get { return this.velocity; }
        }

        public bool IsPushing {
            set { this.isPushing = value; }
            get { return this.isPushing; }
        }

        public Instrument Inst {
            set { this.inst = value; }
            get { return this.inst; }
        }

        public Instrument PreInst {
            set { this.preInst = value; }
            get { return this.preInst; }
        }

        public int[] Now {
            set { this.now = value; }
            get { return this.now; }
        }

        //End MIDIData
    }
}
