using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MIDI_Sessions.MIDI;

namespace MIDI_Sessions.Communication
{
    class UdpCommunication
    {

        private System.Net.Sockets.UdpClient udpClient = null;

        string ipString = "127.0.0.1";
        public int sendPort { set; get; }
        public int recievePort { set; get; }

        public MIDIData midiData { set; get; }

        public void setReciever(ref MIDIData mididata)
        {
            this.midiData = mididata;
        }

        //Button1のClickイベントハンドラ
        //データ受信の待機を開始する
        public void open()
        {
            if (udpClient != null)
            {
                return;
            }

            //UdpClientを作成し、指定したポート番号にバインドする
            System.Net.IPEndPoint localEP = new System.Net.IPEndPoint(
                System.Net.IPAddress.Any, recievePort);
            udpClient = new System.Net.Sockets.UdpClient(localEP);
            //非同期的なデータ受信を開始する
            udpClient.BeginReceive(ReceiveCallback, udpClient);
        }

        //データを受信した時
        private void ReceiveCallback(IAsyncResult ar)
        {
            System.Net.Sockets.UdpClient udp =
                (System.Net.Sockets.UdpClient)ar.AsyncState;

            //非同期受信を終了する
            System.Net.IPEndPoint remoteEP = null;
            byte[] rcvBytes;
            try
            {
                rcvBytes = udp.EndReceive(ar, ref remoteEP);
            }
            catch (System.Net.Sockets.SocketException ex)
            {
                Console.WriteLine("受信エラー({0}/{1})",
                    ex.Message, ex.ErrorCode);
                return;
            }
            catch (ObjectDisposedException ex)
            {
                //すでに閉じている時は終了
                Console.WriteLine("Socketは閉じられています。");
                return;
            }


            midiData = (MIDIData)ByteArrayToObject(rcvBytes);

            //データを文字列に変換する
            //string rcvMsg = System.Text.Encoding.UTF8.GetString(rcvBytes);

            //再びデータ受信を開始する
            udp.BeginReceive(ReceiveCallback, udp);
        }

        //RichTextBox1にメッセージを表示する
        public MIDIData getRecieveMessege()
        {
            return midiData;
        }



        //Button2のClickイベントハンドラ
        //データを送信する
        public void send(MIDIData data)
        {
            //送信するデータを作成する
            byte[] sendBytes = ToByteArray(data);

            //UdpClientを作成する
            if (udpClient == null)
            {
                udpClient = new System.Net.Sockets.UdpClient();
            }

            //非同期的にデータを送信する
            udpClient.BeginSend(sendBytes, sendBytes.Length,
                ipString, sendPort,
                SendCallback, udpClient);
        }

        //データを送信した時
        private void SendCallback(IAsyncResult ar)
        {
            System.Net.Sockets.UdpClient udp =
                (System.Net.Sockets.UdpClient)ar.AsyncState;

            //非同期送信を終了する
            try
            {
                udp.EndSend(ar);
            }
            catch (System.Net.Sockets.SocketException ex)
            {
                Console.WriteLine("送信エラー({0}/{1})",
                    ex.Message, ex.ErrorCode);
            }
            catch (ObjectDisposedException ex)
            {
                //すでに閉じている時は終了
                Console.WriteLine("Socketは閉じられています。");
            }
        }

        //フォームのFormClosedイベントハンドラ
        public void close()
        {
            //UdpClientを閉じる
            if (udpClient != null)
            {
                udpClient.Close();
            }
        }


        public static byte[] ToByteArray(object source)
        {
            var formatter = new BinaryFormatter();
            using (var stream = new MemoryStream())
            {
                formatter.Serialize(stream, source);
                return stream.ToArray();
            }
        }
        public static Object ByteArrayToObject(byte[] arrBytes)
        {
            using (var memStream = new MemoryStream())
            {
                var binForm = new BinaryFormatter();
                memStream.Write(arrBytes, 0, arrBytes.Length);
                memStream.Seek(0, SeekOrigin.Begin);
                var obj = binForm.Deserialize(memStream);
                return obj;
            }
        }

    }
}
