using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;
using MIDI_Sessions.MIDI;

namespace MIDI_Sessions.Communication {
    class UdpCommunication {

        // プライベートなフィールド

        private System.Net.Sockets.UdpClient udpClient = null;

        private string ipString = "127.0.0.1";
        private int sendPort { set; get; }
        private int recievePort { set; get; }

        MIDIData midiData { set; get; }

        private BaseAdapter mainform { set; get; }

        /// <summary>
        /// 通信の設定をします
        /// </summary>
        /// <param name="mainform">BaseAdapterを継承したクラス</param>
        /// <param name="ipString">通信先のIPアドレス</param>
        /// <param name="sendPort">送信に使用するポート番号</param>
        /// <param name="recievePort">受信に使用するポート番号</param>
        public UdpCommunication(BaseAdapter mainform, string ipString, int sendPort, int recievePort) {
            this.mainform = mainform;
            this.ipString = ipString;
            this.sendPort = sendPort;
            this.recievePort = recievePort;
        }

        /// <summary>
        /// データ受信の待機を開始します
        /// </summary>
        public void open() {
            if (udpClient != null) {
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
        private void ReceiveCallback(IAsyncResult ar) {
            Console.WriteLine("データを受信しました");
            UdpClient udp =
                (UdpClient)ar.AsyncState;

            //非同期受信を終了する
            IPEndPoint remoteEP = null;
            byte[] rcvBytes;
            try {
                rcvBytes = udp.EndReceive(ar, ref remoteEP);
            } catch (System.Net.Sockets.SocketException ex) {
                Console.WriteLine("受信エラー({0}/{1})",
                    ex.Message, ex.ErrorCode);
                udp.BeginReceive(ReceiveCallback, udp);
                return;
            } catch (ObjectDisposedException ex) {
                //すでに閉じている時は終了
                Console.WriteLine("Socketは閉じられています。");
                return;
            }


            midiData = (MIDIData)ByteArrayToObject(rcvBytes);
            mainform.recievedProcess(midiData);

            //データを文字列に変換する
            //string rcvMsg = System.Text.Encoding.UTF8.GetString(rcvBytes);

            //再びデータ受信を開始する
            udp.BeginReceive(ReceiveCallback, udp);
        }

        //RichTextBox1にメッセージを表示する
        public MIDIData getRecieveMessege() {
            return midiData;
        }



        /// <summary>
        /// 引数のデータを送信します
        /// </summary>
        /// <param name="data"></param>
        public void send(MIDIData data) {
            //送信するデータを作成する
            byte[] sendBytes = ToByteArray(data);

            //UdpClientを作成する
            if (udpClient == null) {
                udpClient = new System.Net.Sockets.UdpClient();
            }

            //非同期的にデータを送信する
            udpClient.BeginSend(sendBytes, sendBytes.Length,
                ipString, sendPort,
                SendCallback, udpClient);
        }

        //データを送信した時
        private void SendCallback(IAsyncResult ar) {
            System.Net.Sockets.UdpClient udp =
                (System.Net.Sockets.UdpClient)ar.AsyncState;

            //非同期送信を終了する
            try {
                udp.EndSend(ar);
            } catch (System.Net.Sockets.SocketException ex) {
                Console.WriteLine("送信エラー({0}/{1})",
                    ex.Message, ex.ErrorCode);
            } catch (ObjectDisposedException ex) {
                //すでに閉じている時は終了
                Console.WriteLine("Socketは閉じられています。");
            }
        }

        /// <summary>
        /// クライアントを閉じます
        /// </summary>
        public void close() {
            //UdpClientを閉じる
            if (udpClient != null) {
                udpClient.Close();
            }
        }

        /// <summary>
        /// オブジェクトをバイト配列に変換します
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static byte[] ToByteArray(object source) {
            var formatter = new BinaryFormatter();
            using (var stream = new MemoryStream()) {
                formatter.Serialize(stream, source);
                return stream.ToArray();
            }
        }

        /// <summary>
        /// バイト配列をオブジェクトに変換します
        /// </summary>
        /// <param name="arrBytes"></param>
        /// <returns></returns>
        public static Object ByteArrayToObject(byte[] arrBytes) {
            using (var memStream = new MemoryStream()) {
                var binForm = new BinaryFormatter();
                memStream.Write(arrBytes, 0, arrBytes.Length);
                memStream.Seek(0, SeekOrigin.Begin);
                var obj = binForm.Deserialize(memStream);
                return obj;
            }
        }

    }
}
