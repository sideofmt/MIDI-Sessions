using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.ServiceModel.WebSockets;
using System.Net.WebSockets;
using System.Threading;

namespace MIDI_Sessions.Communication
{
    //class WebSocketClient
    //{
    //    static void Main(string[] args)
    //    {
    //        // WebSocket クライアント生成
    //        var client = new Socket("ws://localhost:1234/chat");

    //        // WebSocket サーバーからメッセージが送られてきたら
    //        // コンソールに表示
    //        client.OnData += (sender, e) =>
    //        {
    //            Console.WriteLine("from server: " + e.TextData);
    //        };

    //        // WebSocket サーバーに接続
    //        client.Open();

    //        while (true)
    //        {
    //            var message = Console.ReadLine();

    //            // 入力されたメッセージをサーバーに送信
    //            client.SendMessage(message);
    //        }
    //    }

    //    internal class Socket : WebSocket
    //    {
    //        public override WebSocketCloseStatus? CloseStatus
    //        {
    //            get
    //            {
    //                throw new NotImplementedException();
    //            }
    //        }

    //        public override string CloseStatusDescription
    //        {
    //            get
    //            {
    //                throw new NotImplementedException();
    //            }
    //        }

    //        public override WebSocketState State
    //        {
    //            get
    //            {
    //                throw new NotImplementedException();
    //            }
    //        }

    //        public override string SubProtocol
    //        {
    //            get
    //            {
    //                throw new NotImplementedException();
    //            }
    //        }

    //        public override void Abort()
    //        {
    //            throw new NotImplementedException();
    //        }

    //        public override Task CloseAsync(WebSocketCloseStatus closeStatus, string statusDescription, CancellationToken cancellationToken)
    //        {
    //            throw new NotImplementedException();
    //        }

    //        public override Task CloseOutputAsync(WebSocketCloseStatus closeStatus, string statusDescription, CancellationToken cancellationToken)
    //        {
    //            throw new NotImplementedException();
    //        }

    //        public override void Dispose()
    //        {
    //            throw new NotImplementedException();
    //        }

    //        public override Task<WebSocketReceiveResult> ReceiveAsync(ArraySegment<byte> buffer, CancellationToken cancellationToken)
    //        {
    //            throw new NotImplementedException();
    //        }

    //        public override Task SendAsync(ArraySegment<byte> buffer, WebSocketMessageType messageType, bool endOfMessage, CancellationToken cancellationToken)
    //        {
    //            throw new NotImplementedException();
    //        }
    //    }
    //}
}