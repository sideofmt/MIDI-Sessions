using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Midi;

namespace MIDI_Sessions.MIDI{
    class MIDIData{
        //演奏している際に他ユーザに送るMidiのデータを含むクラス。

        private Channel cha;    //MIDIチャンネル。基本的にユーザ1人に対して1つのチャンネルが与えられる。
        private Pitch pit;      //音高。
        private int velocity;   //ベロシティ。音の強さ。
        private bool isPushing; //キーボードが押されているかを判断。押されている場合はTrue。

        public MIDIData(Channel cha, Pitch pit, int velocity, bool isPushing) {
            this.cha = cha;
            this.pit = pit;
            this.velocity = velocity;
            this.isPushing = isPushing;
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

        //End MIDIData
    }
}
