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
            ((System.ComponentModel.ISupportInitialize)(this.VelocityBar)).BeginInit();
            this.SuspendLayout();
            // 
            // PlayMidi
            // 
            this.PlayMidi.Location = new System.Drawing.Point(319, 306);
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
            this.VelocityLabel2.Location = new System.Drawing.Point(11, 271);
            this.VelocityLabel2.Name = "VelocityLabel2";
            this.VelocityLabel2.Size = new System.Drawing.Size(63, 24);
            this.VelocityLabel2.TabIndex = 6;
            this.VelocityLabel2.Text = "100";
            this.VelocityLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InstList
            // 
            this.InstList.FormattingEnabled = true;
            this.InstList.ItemHeight = 12;
            this.InstList.Location = new System.Drawing.Point(92, 31);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 341);
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
    }
}

