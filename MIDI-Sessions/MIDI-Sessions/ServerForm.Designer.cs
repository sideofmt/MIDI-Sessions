namespace MIDI_Sessions {
    partial class ServerForm {
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
            this.button1 = new System.Windows.Forms.Button();
            this.MemberList = new System.Windows.Forms.ListBox();
            this.ServerIPAddress = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.ListLabel = new System.Windows.Forms.Label();
            this.OKButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(164, 114);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // MemberList
            // 
            this.MemberList.FormattingEnabled = true;
            this.MemberList.ItemHeight = 12;
            this.MemberList.Location = new System.Drawing.Point(15, 49);
            this.MemberList.Name = "MemberList";
            this.MemberList.Size = new System.Drawing.Size(120, 88);
            this.MemberList.TabIndex = 1;
            // 
            // ServerIPAddress
            // 
            this.ServerIPAddress.AutoSize = true;
            this.ServerIPAddress.Location = new System.Drawing.Point(13, 11);
            this.ServerIPAddress.Name = "ServerIPAddress";
            this.ServerIPAddress.Size = new System.Drawing.Size(90, 12);
            this.ServerIPAddress.TabIndex = 2;
            this.ServerIPAddress.Text = "Your IPAddress :";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(109, 11);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(35, 12);
            this.addressLabel.TabIndex = 3;
            this.addressLabel.Text = "0.0.0.0";
            // 
            // ListLabel
            // 
            this.ListLabel.AutoSize = true;
            this.ListLabel.Location = new System.Drawing.Point(13, 34);
            this.ListLabel.Name = "ListLabel";
            this.ListLabel.Size = new System.Drawing.Size(45, 12);
            this.ListLabel.TabIndex = 4;
            this.ListLabel.Text = "Member";
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(164, 82);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 5;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OK_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ServerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 160);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.ListLabel);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.ServerIPAddress);
            this.Controls.Add(this.MemberList);
            this.Controls.Add(this.button1);
            this.Name = "ServerForm";
            this.Text = "ServerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox MemberList;
        private System.Windows.Forms.Label ServerIPAddress;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label ListLabel;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Timer timer1;
    }
}