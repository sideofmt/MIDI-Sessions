using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MIDI_Sessions
{
    public partial class AccessForm : Form
    {
        bool IsParent;
        string ipAddress;
        int sendPort;
        int recievePort;
        Communication.UdpCommunication udp;

        MIDIdata midiData;

        public AccessForm()
        {
            InitializeComponent();
            IsParent = true;
            ipAddress = "localhost";
            sendPort = 8000;
            recievePort = 8001;

            radioButton1.Checked = true;
            textBox1.Enabled = false;
            textBox2.Text = "8000";
            textBox3.Text = "8001";

            udp = new Communication.UdpCommunication();

            midiData = new MIDIdata();
            midiData.str = "send";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // 閉じるボタン
            udp.close();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IsParent = false;

            if (radioButton1.Checked)
            {
                ipAddress = "localhost";
            }
            else if (radioButton2.Checked)
            {
                ipAddress = this.textBox1.Text;
            }
            else
            {
                return;
            }


            Task<MIDIdata> miditask = MIDItask();

            MIDIdata data = miditask.Result;

            sendPort = int.Parse(textBox2.Text);
            recievePort = int.Parse(textBox3.Text);
            udp.setReciever(ref label4);

            udp.sendPort = sendPort;
            udp.recievePort = recievePort;
            udp.open();

        }

        private async Task<MIDIdata> MIDItask()
        {
            MIDIdata midi = new MIDIdata();

            var a = await Task.Run(() =>
            {

                return a;
            });

            return midi;
        }



        private void button3_Click(object sender, EventArgs e)
        {
            udp.send(midiData);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
        }
    }
}
