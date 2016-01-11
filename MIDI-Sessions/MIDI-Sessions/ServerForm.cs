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
using MIDI_Sessions.MIDI;

namespace MIDI_Sessions {
    public partial class ServerForm : Form {
        private string IPv4;
        private List<string> memberList;

        public bool IsCancel { get; set; }

        public ServerForm(string IPv4) {
            InitializeComponent();
            this.IPv4 = IPv4;
            IsCancel = false;
            memberList = new List<string>();

            this.addressLabel.Text = IPv4;

            this.MemberList.Items.Add(IPv4);
        }

        /// <summary>
        /// OKボタンが押された時の処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Cancel_Click(object sender, EventArgs e) {
            IsCancel = true;
            this.Close();
        }

        /// <summary>
        /// Cancelボタンが押された時の処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OK_Click(object sender, EventArgs e) {
            IsCancel = false;
            this.Close();
        }

        /// <summary>
        /// メンバーを追加する時の処理
        /// </summary>
        /// <param name="address"></param>
        private void AddMember(string address) {
            this.MemberList.Items.Add(address);

            return;
        }

        ///// <summary>
        ///// メッセージをクライアント側に送信する
        ///// </summary>
        ///// <param name="memberIPv4"></param>
        //private void SendMessage(List<string> memberList) {
        //    for (int i = 1; i < memberList.Count; i++) {
        //        GetMessage(memberList[i]);
        //    }

        //    return;
        //}

        ///// <summary>
        ///// メッセージをクライアント側から受信する
        ///// </summary>
        ///// <param name="memberIPv4"></param>
        //private void GetMessage(string IPv4) {
        //    if (!this.memberList.Equals(memberList)) {
        //        AddMember(IPv4);
        //    }

        //    return;
        //}

        /// <summary>
        /// メッセージをクライアント側に送信する
        /// </summary>
        /// <param name="memberIPv4"></param>
        private void SendMessage() { 

            return;
        }

        /// <summary>
        /// メッセージをクライアント側から受信する
        /// </summary>
        /// <param name="memberIPv4"></param>
        private void GetMessage() {

            return;
        }

        private void timer1_Tick(object sender, EventArgs e) {
                        
        }

        //End ServerForm
    }
}
