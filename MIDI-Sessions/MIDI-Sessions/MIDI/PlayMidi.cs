using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Midi;

namespace MIDI_Sessions.MIDI {
    class PlayMidi : IPlayMidi {
        private MIDIData midiData;          //MIDIData。
        private string midiFile;            //
        private bool isMidiData = false;    /*オブジェクト生成時にコンストラクタに渡されたデータが、
                                             *MIDIDataかMidiファイルかを判断。
                                             *MIDIDataである場合はTrue。 
                                             */
        private OutputDevice outputDevice;  //Midiを再生する際に使用?
        
        /*--引数がMIDIDataの場合のコンストラクタ--*/
        public PlayMidi(MIDIData midiData) {
            this.midiData = midiData;
            isMidiData = true;
        }

        /*--引数がMidiファイルの場合のコンストラクタ--*/
        public PlayMidi(string midiFile) {
            this.midiFile = midiFile;
            isMidiData = false;
        }

        /*--Midiの再生--*/
        public void Run() {
            if (isMidiData) playMIDIData();
            else playMidiFile();
            return;
        }

        /*--MIDIDataの再生--*/
        public void playMIDIData() {
            outputDevice = SessionUtil.ChooseOutpuDevice();
            if (outputDevice == null) {
                return;
            }
            outputDevice.Open();
            outputDevice.SendNoteOn(midiData.Cha, midiData.Pit, midiData.Velocity);
            while (true) {
                if (!midiData.IsPushing) break;
            }
            outputDevice.SendNoteOff(midiData.Cha, midiData.Pit, midiData.Velocity);
            outputDevice.Close();

            return;
        }

        /*--Midiファイルの再生--*/
        public void playMidiFile() {

            return;
        } 
    }
}
