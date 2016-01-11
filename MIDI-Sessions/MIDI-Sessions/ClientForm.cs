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
    public partial class ClientForm : Form, BaseAdapter {
        private string IPv4;
        private List<string> memberIPv4;

        public bool IsCancel { get; set; }

        public ClientForm(string IPv4) {
            InitializeComponent();
            this.IPv4 = IPv4;
            IsCancel = false;
            memberIPv4 = new List<string>();

            this.addressLabel.Text = IPv4;
        }

        /// <summary>
        /// サーバからのメッセージを受け取り演奏フェーズに移る際の処理
        /// </summary>
        private void Connect() {
            IsCancel = false;
            this.Close();
        }

        /// <summary>
        /// Cancelボタンが押された時の処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Cancel_Click(object sender, EventArgs e) {
            IsCancel = true;
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

        void BaseAdapter.recievedProcess(MIDI.MIDIData mididata) {

        }

        ///// <summary>
        ///// メッセージをサーバ側に送信する
        ///// </summary>
        ///// <param name="memberIPv4"></param>
        //private void SendMessage(string IPv4) {


        //    return;
        //}

        ///// <summary>
        ///// メッセージをサーバ側から受信する
        ///// </summary>
        ///// <param name="memberIPv4"></param>
        //private void GetMessage(List<string> memberIPv4) {
        //    if (!this.memberIPv4.Equals(memberIPv4)) {
        //        this.MemberList.Items.Clear();
        //        foreach(string member in memberIPv4){
        //            this.MemberList.Items.Add(member);
        //        }
        //    }

        //    SendMessage(IPv4);

        //    return;
        //}

        /// <summary>
        /// メッセージをサーバ側から受信する
        /// </summary>
        /// <param name="memberIPv4"></param>
        private void GetMessage() {

            return;
        }

        /// <summary>
        /// メッセージをサーバ側に送信する
        /// </summary>
        /// <param name="memberIPv4"></param>
        private void SendMessage(string IPv4) {

            return;
        }

        private void timer1_Tick(object sender, EventArgs e) {

        }

        //End ClientForm
    }
}
