using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIDI_Sessions.MIDI {
    interface IPlayMidi {
        //MidiData及びMidiファイルを再生するインタフェース。

        void Run(); //Midiの再生。

        /**-------------- 以上 -------------**/
    }
}
