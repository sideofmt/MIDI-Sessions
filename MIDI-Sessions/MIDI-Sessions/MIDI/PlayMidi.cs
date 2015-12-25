using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Midi;

namespace MIDI_Sessions.MIDI {
    public abstract class PlayMidi {
        private MIDIData midi;
        public abstract void Run();
    }
}
