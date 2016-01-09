namespace MIDI_Sessions
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.PlayMidi = new System.Windows.Forms.Button();
            this.VelocityBar = new System.Windows.Forms.TrackBar();
            this.VelocityLabel = new System.Windows.Forms.Label();
            this.VelocityLabel2 = new System.Windows.Forms.Label();
            this.InstList = new System.Windows.Forms.ListBox();
            this.InstLabel = new System.Windows.Forms.Label();
            this.MemberList = new System.Windows.Forms.ListBox();
            this.MemberLabel = new System.Windows.Forms.Label();
            this.number1 = new System.Windows.Forms.TextBox();
            this.ConnectLabel = new System.Windows.Forms.Label();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.dot1 = new System.Windows.Forms.Label();
            this.number2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.number4 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.number3 = new System.Windows.Forms.TextBox();
            this.ConnectLocalhost = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.VelocityBar)).BeginInit();
            this.SuspendLayout();
            // 
            // PlayMidi
            // 
            this.PlayMidi.Location = new System.Drawing.Point(265, 264);
            this.PlayMidi.Name = "PlayMidi";
            this.PlayMidi.Size = new System.Drawing.Size(75, 23);
            this.PlayMidi.TabIndex = 2;
            this.PlayMidi.Text = "PlayMidi";
            this.PlayMidi.UseVisualStyleBackColor = true;
            this.PlayMidi.Click += new System.EventHandler(this.PlayMidi_Click);
            // 
            // VelocityBar
            // 
            this.VelocityBar.Location = new System.Drawing.Point(19, 31);
            this.VelocityBar.Maximum = 127;
            this.VelocityBar.Name = "VelocityBar";
            this.VelocityBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.VelocityBar.Size = new System.Drawing.Size(45, 237);
            this.VelocityBar.SmallChange = 0;
            this.VelocityBar.TabIndex = 3;
            this.VelocityBar.Tag = "";
            this.VelocityBar.TickFrequency = 10;
            this.VelocityBar.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.VelocityBar.Value = 100;
            this.VelocityBar.Scroll += new System.EventHandler(this.VelocityBar_Scroll);
            // 
            // VelocityLabel
            // 
            this.VelocityLabel.AutoSize = true;
            this.VelocityLabel.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.VelocityLabel.Location = new System.Drawing.Point(12, 9);
            this.VelocityLabel.Name = "VelocityLabel";
            this.VelocityLabel.Size = new System.Drawing.Size(62, 16);
            this.VelocityLabel.TabIndex = 5;
            this.VelocityLabel.Text = "Velocity";
            // 
            // VelocityLabel2
            // 
            this.VelocityLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VelocityLabel2.AutoEllipsis = true;
            this.VelocityLabel2.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.VelocityLabel2.Location = new System.Drawing.Point(15, 264);
            this.VelocityLabel2.Name = "VelocityLabel2";
            this.VelocityLabel2.Size = new System.Drawing.Size(49, 23);
            this.VelocityLabel2.TabIndex = 6;
            this.VelocityLabel2.Text = "100";
            this.VelocityLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InstList
            // 
            this.InstList.FormattingEnabled = true;
            this.InstList.ItemHeight = 12;
            this.InstList.Location = new System.Drawing.Point(91, 31);
            this.InstList.Name = "InstList";
            this.InstList.Size = new System.Drawing.Size(149, 256);
            this.InstList.TabIndex = 7;
            this.InstList.SelectedIndexChanged += new System.EventHandler(this.InstList_SelectedIndexChanged);
            // 
            // InstLabel
            // 
            this.InstLabel.AutoSize = true;
            this.InstLabel.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.InstLabel.Location = new System.Drawing.Point(123, 9);
            this.InstLabel.Name = "InstLabel";
            this.InstLabel.Size = new System.Drawing.Size(81, 16);
            this.InstLabel.TabIndex = 8;
            this.InstLabel.Text = "Instrument";
            // 
            // MemberList
            // 
            this.MemberList.FormattingEnabled = true;
            this.MemberList.ItemHeight = 12;
            this.MemberList.Location = new System.Drawing.Point(265, 31);
            this.MemberList.Name = "MemberList";
            this.MemberList.Size = new System.Drawing.Size(120, 88);
            this.MemberList.TabIndex = 9;
            // 
            // MemberLabel
            // 
            this.MemberLabel.AutoSize = true;
            this.MemberLabel.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.MemberLabel.Location = new System.Drawing.Point(291, 12);
            this.MemberLabel.Name = "MemberLabel";
            this.MemberLabel.Size = new System.Drawing.Size(62, 16);
            this.MemberLabel.TabIndex = 10;
            this.MemberLabel.Text = "Member";
            // 
            // number1
            // 
            this.number1.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.number1.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.number1.Location = new System.Drawing.Point(265, 152);
            this.number1.MaxLength = 3;
            this.number1.Name = "number1";
            this.number1.Size = new System.Drawing.Size(33, 19);
            this.number1.TabIndex = 11;
            // 
            // ConnectLabel
            // 
            this.ConnectLabel.AutoSize = true;
            this.ConnectLabel.Location = new System.Drawing.Point(263, 137);
            this.ConnectLabel.Name = "ConnectLabel";
            this.ConnectLabel.Size = new System.Drawing.Size(73, 12);
            this.ConnectLabel.TabIndex = 12;
            this.ConnectLabel.Text = "Connect IPv4";
            // 
            // ConnectButton
            // 
            this.ConnectButton.Location = new System.Drawing.Point(265, 177);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(71, 23);
            this.ConnectButton.TabIndex = 13;
            this.ConnectButton.Text = "Connect";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // dot1
            // 
            this.dot1.AutoSize = true;
            this.dot1.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dot1.Location = new System.Drawing.Point(304, 159);
            this.dot1.Margin = new System.Windows.Forms.Padding(0);
            this.dot1.Name = "dot1";
            this.dot1.Size = new System.Drawing.Size(7, 12);
            this.dot1.TabIndex = 14;
            this.dot1.Text = ".";
            // 
            // number2
            // 
            this.number2.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.number2.Location = new System.Drawing.Point(317, 152);
            this.number2.MaxLength = 3;
            this.number2.Name = "number2";
            this.number2.Size = new System.Drawing.Size(36, 19);
            this.number2.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(359, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(7, 12);
            this.label1.TabIndex = 16;
            this.label1.Text = ".";
            // 
            // number4
            // 
            this.number4.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.number4.Location = new System.Drawing.Point(423, 152);
            this.number4.MaxLength = 3;
            this.number4.Name = "number4";
            this.number4.Size = new System.Drawing.Size(36, 19);
            this.number4.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(410, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(7, 12);
            this.label3.TabIndex = 18;
            this.label3.Text = ".";
            // 
            // number3
            // 
            this.number3.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.number3.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.number3.Location = new System.Drawing.Point(371, 152);
            this.number3.MaxLength = 3;
            this.number3.Name = "number3";
            this.number3.Size = new System.Drawing.Size(33, 19);
            this.number3.TabIndex = 17;
            // 
            // ConnectLocalhost
            // 
            this.ConnectLocalhost.Location = new System.Drawing.Point(265, 206);
            this.ConnectLocalhost.Name = "ConnectLocalhost";
            this.ConnectLocalhost.Size = new System.Drawing.Size(120, 23);
            this.ConnectLocalhost.TabIndex = 20;
            this.ConnectLocalhost.Text = "Connect Localhost";
            this.ConnectLocalhost.UseVisualStyleBackColor = true;
            this.ConnectLocalhost.Click += new System.EventHandler(this.ConnectLocalhost_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 340);
            this.Controls.Add(this.ConnectLocalhost);
            this.Controls.Add(this.number4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.number3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.number2);
            this.Controls.Add(this.dot1);
            this.Controls.Add(this.ConnectButton);
            this.Controls.Add(this.ConnectLabel);
            this.Controls.Add(this.number1);
            this.Controls.Add(this.MemberLabel);
            this.Controls.Add(this.MemberList);
            this.Controls.Add(this.InstLabel);
            this.Controls.Add(this.InstList);
            this.Controls.Add(this.VelocityLabel2);
            this.Controls.Add(this.VelocityLabel);
            this.Controls.Add(this.VelocityBar);
            this.Controls.Add(this.PlayMidi);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.VelocityBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PlayMidi;
        private System.Windows.Forms.TrackBar VelocityBar;
        private System.Windows.Forms.Label VelocityLabel;
        private System.Windows.Forms.Label VelocityLabel2;
        private System.Windows.Forms.ListBox InstList;
        private System.Windows.Forms.Label InstLabel;
        private System.Windows.Forms.ListBox MemberList;
        private System.Windows.Forms.Label MemberLabel;
        private System.Windows.Forms.TextBox number1;
        private System.Windows.Forms.Label ConnectLabel;
        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.Label dot1;
        private System.Windows.Forms.TextBox number2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox number4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox number3;
        private System.Windows.Forms.Button ConnectLocalhost;
    }
}

