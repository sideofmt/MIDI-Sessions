using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Midi;

namespace MIDI_Sessions.MIDI {
    class SessionUtil {
        public static OutputDevice ChooseOutpuDevice(){
            if (OutputDevice.InstalledDevices.Count == 0) {
                return null;
            }
            if (OutputDevice.InstalledDevices.Count == 1) {
                return OutputDevice.InstalledDevices[0];
            }
            Console.WriteLine("Output Devices:");
            for (int i = 0; i < OutputDevice.InstalledDevices.Count; ++i) {
                Console.WriteLine("   {0}: {1}", i, OutputDevice.InstalledDevices[i].Name);
            }
            Console.Write("Choose the id of an output device...");
            while (true) {
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                int deviceId = (int)keyInfo.Key - (int)ConsoleKey.D0;
                if (deviceId >= 0 && deviceId < OutputDevice.InstalledDevices.Count) {
                    return OutputDevice.InstalledDevices[deviceId];
                }
            }
        }
    }
}
