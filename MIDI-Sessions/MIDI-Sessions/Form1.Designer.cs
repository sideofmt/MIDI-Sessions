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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.VelocityBar = new System.Windows.Forms.TrackBar();
            this.Channellabel = new System.Windows.Forms.Label();
            this.ChannelBox = new System.Windows.Forms.ComboBox();
            this.Reset = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.NumberOfPerson = new System.Windows.Forms.ComboBox();
            this.radioLocalhost = new System.Windows.Forms.RadioButton();
            this.IPGroup = new System.Windows.Forms.GroupBox();
            this.number4 = new System.Windows.Forms.TextBox();
            this.number1 = new System.Windows.Forms.TextBox();
            this.dot1 = new System.Windows.Forms.Label();
            this.number2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.number3 = new System.Windows.Forms.TextBox();
            this.radioClientButton = new System.Windows.Forms.RadioButton();
            this.radioServerButton = new System.Windows.Forms.RadioButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.DisconnectButton = new System.Windows.Forms.Button();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.MemberLabel = new System.Windows.Forms.Label();
            this.MemberList = new System.Windows.Forms.ListBox();
            this.InstLabel = new System.Windows.Forms.Label();
            this.InstList = new System.Windows.Forms.ListBox();
            this.VelocityLabel2 = new System.Windows.Forms.Label();
            this.VelocityLabel = new System.Windows.Forms.Label();
            this.KeyGroup = new System.Windows.Forms.GroupBox();
            this.labelCHigh = new System.Windows.Forms.Label();
            this.labelB = new System.Windows.Forms.Label();
            this.labelASha = new System.Windows.Forms.Label();
            this.labelA = new System.Windows.Forms.Label();
            this.labelGSha = new System.Windows.Forms.Label();
            this.labelG = new System.Windows.Forms.Label();
            this.labelFSha = new System.Windows.Forms.Label();
            this.labelF = new System.Windows.Forms.Label();
            this.labelE = new System.Windows.Forms.Label();
            this.labelDSha = new System.Windows.Forms.Label();
            this.labelD = new System.Windows.Forms.Label();
            this.labelCSha = new System.Windows.Forms.Label();
            this.labelC = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelOctave = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.VelocityBar)).BeginInit();
            this.IPGroup.SuspendLayout();
            this.KeyGroup.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            // Channellabel
            // 
            this.Channellabel.AutoSize = true;
            this.Channellabel.Location = new System.Drawing.Point(392, 31);
            this.Channellabel.Name = "Channellabel";
            this.Channellabel.Size = new System.Drawing.Size(46, 12);
            this.Channellabel.TabIndex = 30;
            this.Channellabel.Text = "Channel";
            // 
            // ChannelBox
            // 
            this.ChannelBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ChannelBox.FormattingEnabled = true;
            this.ChannelBox.Location = new System.Drawing.Point(444, 28);
            this.ChannelBox.Name = "ChannelBox";
            this.ChannelBox.Size = new System.Drawing.Size(36, 20);
            this.ChannelBox.TabIndex = 29;
            this.ChannelBox.SelectedIndexChanged += new System.EventHandler(this.ChannelBox_SelectedIndexChanged);
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(265, 264);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(88, 23);
            this.Reset.TabIndex = 28;
            this.Reset.Text = "Sound Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(267, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 12);
            this.label2.TabIndex = 27;
            this.label2.Text = "Number Of Member";
            // 
            // NumberOfPerson
            // 
            this.NumberOfPerson.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NumberOfPerson.FormattingEnabled = true;
            this.NumberOfPerson.Location = new System.Drawing.Point(379, 180);
            this.NumberOfPerson.Name = "NumberOfPerson";
            this.NumberOfPerson.Size = new System.Drawing.Size(34, 20);
            this.NumberOfPerson.TabIndex = 26;
            this.NumberOfPerson.SelectedIndexChanged += new System.EventHandler(this.NumberOfPerson_SelectedIndexChanged);
            // 
            // radioLocalhost
            // 
            this.radioLocalhost.AutoSize = true;
            this.radioLocalhost.Location = new System.Drawing.Point(366, 250);
            this.radioLocalhost.Name = "radioLocalhost";
            this.radioLocalhost.Size = new System.Drawing.Size(72, 16);
            this.radioLocalhost.TabIndex = 25;
            this.radioLocalhost.TabStop = true;
            this.radioLocalhost.Text = "Localhost";
            this.radioLocalhost.UseVisualStyleBackColor = true;
            this.radioLocalhost.CheckedChanged += new System.EventHandler(this.radioLocalhost_CheckedChanged);
            // 
            // IPGroup
            // 
            this.IPGroup.Controls.Add(this.number4);
            this.IPGroup.Controls.Add(this.number1);
            this.IPGroup.Controls.Add(this.dot1);
            this.IPGroup.Controls.Add(this.number2);
            this.IPGroup.Controls.Add(this.label1);
            this.IPGroup.Controls.Add(this.label3);
            this.IPGroup.Controls.Add(this.number3);
            this.IPGroup.Location = new System.Drawing.Point(265, 123);
            this.IPGroup.Name = "IPGroup";
            this.IPGroup.Size = new System.Drawing.Size(235, 48);
            this.IPGroup.TabIndex = 24;
            this.IPGroup.TabStop = false;
            this.IPGroup.Text = "IPaddress";
            // 
            // number4
            // 
            this.number4.Enabled = false;
            this.number4.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.number4.Location = new System.Drawing.Point(176, 18);
            this.number4.MaxLength = 3;
            this.number4.Name = "number4";
            this.number4.Size = new System.Drawing.Size(36, 19);
            this.number4.TabIndex = 19;
            // 
            // number1
            // 
            this.number1.Enabled = false;
            this.number1.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.number1.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.number1.Location = new System.Drawing.Point(18, 18);
            this.number1.MaxLength = 3;
            this.number1.Name = "number1";
            this.number1.Size = new System.Drawing.Size(33, 19);
            this.number1.TabIndex = 11;
            // 
            // dot1
            // 
            this.dot1.AutoSize = true;
            this.dot1.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dot1.Location = new System.Drawing.Point(57, 25);
            this.dot1.Margin = new System.Windows.Forms.Padding(0);
            this.dot1.Name = "dot1";
            this.dot1.Size = new System.Drawing.Size(7, 12);
            this.dot1.TabIndex = 14;
            this.dot1.Text = ".";
            // 
            // number2
            // 
            this.number2.Enabled = false;
            this.number2.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.number2.Location = new System.Drawing.Point(70, 18);
            this.number2.MaxLength = 3;
            this.number2.Name = "number2";
            this.number2.Size = new System.Drawing.Size(36, 19);
            this.number2.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(112, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(7, 12);
            this.label1.TabIndex = 16;
            this.label1.Text = ".";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(163, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(7, 12);
            this.label3.TabIndex = 18;
            this.label3.Text = ".";
            // 
            // number3
            // 
            this.number3.Enabled = false;
            this.number3.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.number3.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.number3.Location = new System.Drawing.Point(124, 18);
            this.number3.MaxLength = 3;
            this.number3.Name = "number3";
            this.number3.Size = new System.Drawing.Size(33, 19);
            this.number3.TabIndex = 17;
            // 
            // radioClientButton
            // 
            this.radioClientButton.AutoSize = true;
            this.radioClientButton.Location = new System.Drawing.Point(366, 228);
            this.radioClientButton.Name = "radioClientButton";
            this.radioClientButton.Size = new System.Drawing.Size(53, 16);
            this.radioClientButton.TabIndex = 23;
            this.radioClientButton.Text = "Client";
            this.radioClientButton.UseVisualStyleBackColor = true;
            this.radioClientButton.CheckedChanged += new System.EventHandler(this.radioClientButton_CheckedChanged);
            // 
            // radioServerButton
            // 
            this.radioServerButton.AutoSize = true;
            this.radioServerButton.Checked = true;
            this.radioServerButton.Location = new System.Drawing.Point(366, 206);
            this.radioServerButton.Name = "radioServerButton";
            this.radioServerButton.Size = new System.Drawing.Size(56, 16);
            this.radioServerButton.TabIndex = 22;
            this.radioServerButton.TabStop = true;
            this.radioServerButton.Text = "Server";
            this.radioServerButton.UseVisualStyleBackColor = true;
            this.radioServerButton.CheckedChanged += new System.EventHandler(this.radioServerButton_CheckedChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // DisconnectButton
            // 
            this.DisconnectButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.DisconnectButton.Location = new System.Drawing.Point(265, 235);
            this.DisconnectButton.Name = "DisconnectButton";
            this.DisconnectButton.Size = new System.Drawing.Size(88, 23);
            this.DisconnectButton.TabIndex = 21;
            this.DisconnectButton.Text = "Disconnect";
            this.DisconnectButton.UseVisualStyleBackColor = true;
            this.DisconnectButton.Click += new System.EventHandler(this.DisconnectButton_Click);
            // 
            // ConnectButton
            // 
            this.ConnectButton.Location = new System.Drawing.Point(265, 206);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(88, 23);
            this.ConnectButton.TabIndex = 13;
            this.ConnectButton.Text = "Connect";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
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
            // MemberList
            // 
            this.MemberList.FormattingEnabled = true;
            this.MemberList.ItemHeight = 12;
            this.MemberList.Location = new System.Drawing.Point(265, 31);
            this.MemberList.Name = "MemberList";
            this.MemberList.Size = new System.Drawing.Size(120, 88);
            this.MemberList.TabIndex = 9;
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
            // VelocityLabel2
            // 
            this.VelocityLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VelocityLabel2.AutoEllipsis = true;
            this.VelocityLabel2.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.VelocityLabel2.Location = new System.Drawing.Point(6, 264);
            this.VelocityLabel2.Name = "VelocityLabel2";
            this.VelocityLabel2.Size = new System.Drawing.Size(68, 28);
            this.VelocityLabel2.TabIndex = 6;
            this.VelocityLabel2.Text = "100";
            this.VelocityLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // KeyGroup
            // 
            this.KeyGroup.Controls.Add(this.labelCHigh);
            this.KeyGroup.Controls.Add(this.labelB);
            this.KeyGroup.Controls.Add(this.labelASha);
            this.KeyGroup.Controls.Add(this.labelA);
            this.KeyGroup.Controls.Add(this.labelGSha);
            this.KeyGroup.Controls.Add(this.labelG);
            this.KeyGroup.Controls.Add(this.labelFSha);
            this.KeyGroup.Controls.Add(this.labelF);
            this.KeyGroup.Controls.Add(this.labelE);
            this.KeyGroup.Controls.Add(this.labelDSha);
            this.KeyGroup.Controls.Add(this.labelD);
            this.KeyGroup.Controls.Add(this.labelCSha);
            this.KeyGroup.Controls.Add(this.labelC);
            this.KeyGroup.Location = new System.Drawing.Point(12, 310);
            this.KeyGroup.Name = "KeyGroup";
            this.KeyGroup.Size = new System.Drawing.Size(423, 48);
            this.KeyGroup.TabIndex = 31;
            this.KeyGroup.TabStop = false;
            this.KeyGroup.Text = "Key";
            // 
            // labelCHigh
            // 
            this.labelCHigh.AutoSize = true;
            this.labelCHigh.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelCHigh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(0)))), ((int)(((byte)(18)))));
            this.labelCHigh.Location = new System.Drawing.Point(389, 15);
            this.labelCHigh.Name = "labelCHigh";
            this.labelCHigh.Size = new System.Drawing.Size(30, 27);
            this.labelCHigh.TabIndex = 12;
            this.labelCHigh.Text = "C";
            this.labelCHigh.Visible = false;
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(0)))), ((int)(((byte)(79)))));
            this.labelB.Location = new System.Drawing.Point(367, 15);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(29, 27);
            this.labelB.TabIndex = 11;
            this.labelB.Text = "B";
            this.labelB.Visible = false;
            // 
            // labelASha
            // 
            this.labelASha.AutoSize = true;
            this.labelASha.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelASha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(0)))), ((int)(((byte)(127)))));
            this.labelASha.Location = new System.Drawing.Point(327, 15);
            this.labelASha.Name = "labelASha";
            this.labelASha.Size = new System.Drawing.Size(43, 27);
            this.labelASha.TabIndex = 10;
            this.labelASha.Text = "A#";
            this.labelASha.Visible = false;
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(7)))), ((int)(((byte)(131)))));
            this.labelA.Location = new System.Drawing.Point(301, 15);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(29, 27);
            this.labelA.TabIndex = 9;
            this.labelA.Text = "A";
            this.labelA.Visible = false;
            // 
            // labelGSha
            // 
            this.labelGSha.AutoSize = true;
            this.labelGSha.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelGSha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(136)))));
            this.labelGSha.Location = new System.Drawing.Point(257, 15);
            this.labelGSha.Name = "labelGSha";
            this.labelGSha.Size = new System.Drawing.Size(44, 27);
            this.labelGSha.TabIndex = 8;
            this.labelGSha.Text = "G#";
            this.labelGSha.Visible = false;
            // 
            // labelG
            // 
            this.labelG.AutoSize = true;
            this.labelG.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelG.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(104)))), ((int)(((byte)(183)))));
            this.labelG.Location = new System.Drawing.Point(230, 15);
            this.labelG.Name = "labelG";
            this.labelG.Size = new System.Drawing.Size(30, 27);
            this.labelG.TabIndex = 7;
            this.labelG.Text = "G";
            this.labelG.Visible = false;
            // 
            // labelFSha
            // 
            this.labelFSha.AutoSize = true;
            this.labelFSha.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelFSha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(233)))));
            this.labelFSha.Location = new System.Drawing.Point(193, 15);
            this.labelFSha.Name = "labelFSha";
            this.labelFSha.Size = new System.Drawing.Size(41, 27);
            this.labelFSha.TabIndex = 6;
            this.labelFSha.Text = "F#";
            this.labelFSha.Visible = false;
            // 
            // labelF
            // 
            this.labelF.AutoSize = true;
            this.labelF.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(158)))), ((int)(((byte)(150)))));
            this.labelF.Location = new System.Drawing.Point(169, 15);
            this.labelF.Name = "labelF";
            this.labelF.Size = new System.Drawing.Size(27, 27);
            this.labelF.TabIndex = 5;
            this.labelF.Text = "F";
            this.labelF.Visible = false;
            // 
            // labelE
            // 
            this.labelE.AutoSize = true;
            this.labelE.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(68)))));
            this.labelE.Location = new System.Drawing.Point(142, 15);
            this.labelE.Name = "labelE";
            this.labelE.Size = new System.Drawing.Size(27, 27);
            this.labelE.TabIndex = 4;
            this.labelE.Text = "E";
            this.labelE.Visible = false;
            // 
            // labelDSha
            // 
            this.labelDSha.AutoSize = true;
            this.labelDSha.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelDSha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(195)))), ((int)(((byte)(31)))));
            this.labelDSha.Location = new System.Drawing.Point(102, 15);
            this.labelDSha.Name = "labelDSha";
            this.labelDSha.Size = new System.Drawing.Size(44, 27);
            this.labelDSha.TabIndex = 3;
            this.labelDSha.Text = "D#";
            this.labelDSha.Visible = false;
            // 
            // labelD
            // 
            this.labelD.AutoSize = true;
            this.labelD.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(0)))));
            this.labelD.Location = new System.Drawing.Point(75, 15);
            this.labelD.Name = "labelD";
            this.labelD.Size = new System.Drawing.Size(30, 27);
            this.labelD.TabIndex = 2;
            this.labelD.Text = "D";
            this.labelD.Visible = false;
            // 
            // labelCSha
            // 
            this.labelCSha.AutoSize = true;
            this.labelCSha.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelCSha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.labelCSha.Location = new System.Drawing.Point(34, 15);
            this.labelCSha.Name = "labelCSha";
            this.labelCSha.Size = new System.Drawing.Size(44, 27);
            this.labelCSha.TabIndex = 1;
            this.labelCSha.Text = "C#";
            this.labelCSha.Visible = false;
            // 
            // labelC
            // 
            this.labelC.AutoSize = true;
            this.labelC.BackColor = System.Drawing.SystemColors.Control;
            this.labelC.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(0)))), ((int)(((byte)(18)))));
            this.labelC.Location = new System.Drawing.Point(11, 15);
            this.labelC.Name = "labelC";
            this.labelC.Size = new System.Drawing.Size(30, 27);
            this.labelC.TabIndex = 0;
            this.labelC.Text = "C";
            this.labelC.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelOctave);
            this.groupBox1.Location = new System.Drawing.Point(437, 310);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(85, 48);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Octave";
            // 
            // labelOctave
            // 
            this.labelOctave.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelOctave.AutoSize = true;
            this.labelOctave.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelOctave.Location = new System.Drawing.Point(19, 15);
            this.labelOctave.Name = "labelOctave";
            this.labelOctave.Size = new System.Drawing.Size(44, 27);
            this.labelOctave.TabIndex = 32;
            this.labelOctave.Text = "C3";
            this.labelOctave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 370);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.KeyGroup);
            this.Controls.Add(this.Channellabel);
            this.Controls.Add(this.ChannelBox);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NumberOfPerson);
            this.Controls.Add(this.radioLocalhost);
            this.Controls.Add(this.IPGroup);
            this.Controls.Add(this.radioClientButton);
            this.Controls.Add(this.radioServerButton);
            this.Controls.Add(this.DisconnectButton);
            this.Controls.Add(this.ConnectButton);
            this.Controls.Add(this.MemberLabel);
            this.Controls.Add(this.MemberList);
            this.Controls.Add(this.InstLabel);
            this.Controls.Add(this.InstList);
            this.Controls.Add(this.VelocityLabel2);
            this.Controls.Add(this.VelocityLabel);
            this.Controls.Add(this.VelocityBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.VelocityBar)).EndInit();
            this.IPGroup.ResumeLayout(false);
            this.IPGroup.PerformLayout();
            this.KeyGroup.ResumeLayout(false);
            this.KeyGroup.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar VelocityBar;
        private System.Windows.Forms.Label Channellabel;
        private System.Windows.Forms.ComboBox ChannelBox;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox NumberOfPerson;
        private System.Windows.Forms.RadioButton radioLocalhost;
        private System.Windows.Forms.GroupBox IPGroup;
        private System.Windows.Forms.TextBox number4;
        private System.Windows.Forms.TextBox number1;
        private System.Windows.Forms.Label dot1;
        private System.Windows.Forms.TextBox number2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox number3;
        private System.Windows.Forms.RadioButton radioClientButton;
        private System.Windows.Forms.RadioButton radioServerButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button DisconnectButton;
        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.Label MemberLabel;
        private System.Windows.Forms.ListBox MemberList;
        private System.Windows.Forms.Label InstLabel;
        private System.Windows.Forms.ListBox InstList;
        private System.Windows.Forms.Label VelocityLabel2;
        private System.Windows.Forms.Label VelocityLabel;
        private System.Windows.Forms.GroupBox KeyGroup;
        private System.Windows.Forms.Label labelCHigh;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.Label labelASha;
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.Label labelGSha;
        private System.Windows.Forms.Label labelG;
        private System.Windows.Forms.Label labelFSha;
        private System.Windows.Forms.Label labelF;
        private System.Windows.Forms.Label labelE;
        private System.Windows.Forms.Label labelDSha;
        private System.Windows.Forms.Label labelD;
        private System.Windows.Forms.Label labelCSha;
        private System.Windows.Forms.Label labelC;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelOctave;

    }
}

