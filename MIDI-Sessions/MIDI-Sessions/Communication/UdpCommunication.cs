using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net;
using System.Net.Sockets;

namespace MIDI_Sessions.Communication
{
    class UdpCommunication
    {
        public async void ListenMessage()
        {
            // 接続ソケットの準備
            var local = new IPEndPoint(IPAddress.Any, 8000);
            var remote = new IPEndPoint(IPAddress.Any, 8000);
            var client = new UdpClient(local);

            while (true)
            {
                // データ受信待機
                var result = await client.ReceiveAsync();

                // 受信したデータを変換
                var data = Encoding.UTF8.GetString(result.Buffer);

                // Receive イベント を実行
                this.OnRecieve(data);
            }
        }

        private void OnRecieve(string data)
        {
            // 受信したときの処理
        }

        public async void SendMessage()
        {
            // 宛先の作成
            var remote = new IPEndPoint(
                                IPAddress.Parse("192.168.0.10"),
                                8000);

            // メッセージの準備
            var message = Encoding.UTF8.GetBytes("Hello world !");

            // UDPでメッセージ送信
            var client = new UdpClient(8000);
            client.Connect(remote);
            await client.SendAsync(message, message.Length);
            client.Close();
        }



    }
}
