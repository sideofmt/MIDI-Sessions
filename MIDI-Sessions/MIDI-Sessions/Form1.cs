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
        private MIDIData midi;

        public Form1(){
            InitializeComponent();
        }

        private void C_Click(object sender, EventArgs e) {
            midi = new MIDIData(Channel.Channel1, Pitch.C3, 80, true);
            IPlayMidi play = new PlayMidi(midi);
            play.Run();
            return;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e) {
            Console.WriteLine(e.KeyCode);
            switch (e.KeyCode) {
                case Keys.A:
                    midi = new MIDIData(Channel.Channel1, Pitch.C3, 100, true);
                    break;
                case Keys.W:
                    midi = new MIDIData(Channel.Channel1, Pitch.CSharp3, 100, true);
                    break;
            }
            IPlayMidi play = new PlayMidi(midi);
            play.Run();
        }

        private void D_Click(object sender, EventArgs e) {

        }

        private void PlayMidi_Click(object sender, EventArgs e) {

        }
    }
}
