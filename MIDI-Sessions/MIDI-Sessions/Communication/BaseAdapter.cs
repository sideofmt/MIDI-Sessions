﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIDI_Sessions.Communication
{
    interface BaseAdapter
    {
        void recievedProcess(MIDI.MIDIData mididata);
    }
}
