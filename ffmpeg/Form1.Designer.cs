namespace ffmpeg
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tip = new System.Windows.Forms.TextBox();
            this.chance_dShow = new System.Windows.Forms.Button();
            this.dShowName = new System.Windows.Forms.ComboBox();
            this.dShow_option = new System.Windows.Forms.ComboBox();
            this.chance_option = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tip
            // 
            this.tip.Location = new System.Drawing.Point(54, 226);
            this.tip.Multiline = true;
            this.tip.Name = "tip";
            this.tip.Size = new System.Drawing.Size(100, 113);
            this.tip.TabIndex = 0;
            // 
            // chance_dShow
            // 
            this.chance_dShow.Location = new System.Drawing.Point(233, 29);
            this.chance_dShow.Name = "chance_dShow";
            this.chance_dShow.Size = new System.Drawing.Size(75, 23);
            this.chance_dShow.TabIndex = 1;
            this.chance_dShow.Text = "选择设备";
            this.chance_dShow.UseVisualStyleBackColor = true;
            this.chance_dShow.Click += new System.EventHandler(this.button1_Click);
            // 
            // dShowName
            // 
            this.dShowName.FormattingEnabled = true;
            this.dShowName.Location = new System.Drawing.Point(54, 31);
            this.dShowName.Name = "dShowName";
            this.dShowName.Size = new System.Drawing.Size(121, 20);
            this.dShowName.TabIndex = 2;
            // 
            // dShow_option
            // 
            this.dShow_option.FormattingEnabled = true;
            this.dShow_option.Location = new System.Drawing.Point(54, 77);
            this.dShow_option.Name = "dShow_option";
            this.dShow_option.Size = new System.Drawing.Size(121, 20);
            this.dShow_option.TabIndex = 3;
            // 
            // chance_option
            // 
            this.chance_option.Location = new System.Drawing.Point(233, 74);
            this.chance_option.Name = "chance_option";
            this.chance_option.Size = new System.Drawing.Size(75, 23);
            this.chance_option.TabIndex = 4;
            this.chance_option.Text = "选择格式";
            this.chance_option.UseVisualStyleBackColor = true;
            this.chance_option.Click += new System.EventHandler(this.chance_option_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 398);
            this.Controls.Add(this.chance_option);
            this.Controls.Add(this.dShow_option);
            this.Controls.Add(this.dShowName);
            this.Controls.Add(this.chance_dShow);
            this.Controls.Add(this.tip);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tip;
        private System.Windows.Forms.Button chance_dShow;
        private System.Windows.Forms.ComboBox dShowName;
        private System.Windows.Forms.ComboBox dShow_option;
        private System.Windows.Forms.Button chance_option;
    }
}

