using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MIDI_Sessions.Communication;

namespace MIDI_Sessions
{
    public partial class Form1 : Form
    {
        DebugMonitor debugMonitor;

        public Form1()
        {
            InitializeComponent();
            //Form2クラスのインスタンスを作成する
            debugMonitor = new DebugMonitor();
            //Form2を表示する
            //ここではモードレスフォームとして表示する
            debugMonitor.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            debugMonitor.setAddText("メインフォームのロードが完了しました");
        }

        private void 終了ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //自分自身のフォームがメインフォームの時、
            //自分自身のフォームをCloseメソッドで閉じると、アプリケーションが終了する
            debugMonitor.setAddText("アプリケーションを終了します");
            this.Close();
        }

        private void 通信の設定ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Form2クラスのインスタンスを作成する
            AccessForm accessForm = new AccessForm();
            //Form2を表示する
            debugMonitor.setAddText("通信設定ダイアログを開きます");
            accessForm.ShowDialog(this);
            debugMonitor.setAddText("通信設定ダイアログを閉じます");
            //フォームが必要なくなったところで、Disposeを呼び出す
            accessForm.Dispose();
        }

        string ipAddress;
        int sendPort;
        int recievePort;
        Communication.UdpCommunication udp;

        MIDIdata sendMidiData;
        MIDIdata recieveMidiData;

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            sendPort = int.Parse("8000");
            recievePort = int.Parse("8001");
            udp.setReciever(ref recieveMidiData);

            udp.sendPort = sendPort;
            udp.recievePort = recievePort;
            udp.open();

            backgroundWorker1.ReportProgress(100);

        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            
        }
        void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("通信を終了しました。", "通知", MessageBoxButtons.OK);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
        }
    }
}
