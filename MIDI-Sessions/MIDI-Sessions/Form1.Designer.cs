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
            this.C = new System.Windows.Forms.Button();
            this.D = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // C
            // 
            this.C.Location = new System.Drawing.Point(12, 12);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(31, 23);
            this.C.TabIndex = 0;
            this.C.Text = "C";
            this.C.UseVisualStyleBackColor = true;
            this.C.Click += new System.EventHandler(this.C_Click);
            // 
            // D
            // 
            this.D.Location = new System.Drawing.Point(13, 42);
            this.D.Name = "D";
            this.D.Size = new System.Drawing.Size(30, 23);
            this.D.TabIndex = 1;
            this.D.Text = "D";
            this.D.UseVisualStyleBackColor = true;
            this.D.Click += new System.EventHandler(this.D_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.D);
            this.Controls.Add(this.C);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button C;
        private System.Windows.Forms.Button D;
    }
}

