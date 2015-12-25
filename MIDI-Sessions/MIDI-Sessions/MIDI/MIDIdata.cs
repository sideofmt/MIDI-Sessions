using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Midi;

namespace MIDI_Sessions.MIDI{
    class MIDIData{
        private Channel cha;
        private Pitch pit;
        private int velocity;
        private bool isPushing;

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
    }
}
