﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Midi;

namespace MIDI_Sessions.MIDI {
    class PlayMidi : IPlayMidi {
        private MIDIData midiData;          //MIDIData。
        private string midiFile;            //MidiFile。
        private bool isMidiData = false;    /*オブジェクト生成時にコンストラクタに渡されたデータが、
                                             *MIDIDataかMidiファイルかを判断。
                                             *MIDIDataである場合はTrue。 
                                             */
        private OutputDevice outputDevice;  //アウトプットデバイス。Midiを再生する際に使用。
        
        /*--引数がMIDIDataの場合のコンストラクタ--*/
        public PlayMidi(MIDIData midiData, OutputDevice outputDevice){
            this.midiData = midiData;
            this.outputDevice = outputDevice;
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

        /*--Midiの停止--*/
        public void Stop() {
            if (isMidiData) stopMIDIData();
            else stopMidiFile();
            return;
        }

        /*--MIDIFileの停止--*/
        public void stopMidiFile() {

        }

        /*--MidiDataの停止--*/
        public void stopMIDIData() {
            Console.WriteLine(midiData.Cha);
            Console.WriteLine(midiData.Pit);
            Console.WriteLine(midiData.Velocity);
            outputDevice.SendNoteOff(midiData.Cha, midiData.Pit, midiData.Velocity);

            return;
        }

        /*--MIDIDataの再生--*/
        public void playMIDIData() {
            outputDevice.SendNoteOn(midiData.Cha, midiData.Pit, midiData.Velocity);

            return;
        }

        /*--Midiファイルの再生--*/
        public void playMidiFile() {

            return;
        }

        //End PlayMidi
    }
}