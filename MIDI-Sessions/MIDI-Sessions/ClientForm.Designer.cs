namespace MIDI_Sessions {
    partial class ClientForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.CancelButton = new System.Windows.Forms.Button();
            this.ListLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.ServerIPAddress = new System.Windows.Forms.Label();
            this.MemberList = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(157, 108);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 11;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // ListLabel
            // 
            this.ListLabel.AutoSize = true;
            this.ListLabel.Location = new System.Drawing.Point(10, 30);
            this.ListLabel.Name = "ListLabel";
            this.ListLabel.Size = new System.Drawing.Size(45, 12);
            this.ListLabel.TabIndex = 10;
            this.ListLabel.Text = "Member";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(106, 7);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(35, 12);
            this.addressLabel.TabIndex = 9;
            this.addressLabel.Text = "0.0.0.0";
            // 
            // ServerIPAddress
            // 
            this.ServerIPAddress.AutoSize = true;
            this.ServerIPAddress.Location = new System.Drawing.Point(10, 7);
            this.ServerIPAddress.Name = "ServerIPAddress";
            this.ServerIPAddress.Size = new System.Drawing.Size(90, 12);
            this.ServerIPAddress.TabIndex = 8;
            this.ServerIPAddress.Text = "Your IPAddress :";
            // 
            // MemberList
            // 
            this.MemberList.FormattingEnabled = true;
            this.MemberList.ItemHeight = 12;
            this.MemberList.Location = new System.Drawing.Point(12, 45);
            this.MemberList.Name = "MemberList";
            this.MemberList.Size = new System.Drawing.Size(120, 88);
            this.MemberList.TabIndex = 7;
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 143);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.ListLabel);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.ServerIPAddress);
            this.Controls.Add(this.MemberList);
            this.Name = "ClientForm";
            this.Text = "ClientForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label ListLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label ServerIPAddress;
        private System.Windows.Forms.ListBox MemberList;
        private System.Windows.Forms.Timer timer1;
    }
}