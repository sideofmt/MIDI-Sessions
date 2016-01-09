using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Midi;

namespace MIDI_Sessions.MIDI {
    //様々な処理を行うクラス。便利屋。
    class SessionUtil {
        //使用するOutputDeviceを決定するためのメソッド。
        //OutputDeviceが複数個あった時の処理は未実装。
        public static OutputDevice ChooseOutpuDevice(){
            if (OutputDevice.InstalledDevices.Count == 1) {
                return OutputDevice.InstalledDevices[0];
            } else {
                return null;
            }
            /*
            if (OutputDevice.InstalledDevices.Count == 0) {
                return null;
            }else if (OutputDevice.InstalledDevices.Count == 1) {
                return OutputDevice.InstalledDevices[0];
            }
            */
        }

        //End SessionUtil
    }
}
