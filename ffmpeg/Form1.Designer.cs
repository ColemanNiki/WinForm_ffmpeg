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
            this.choose_dShow = new System.Windows.Forms.Button();
            this.dShow_Name = new System.Windows.Forms.ComboBox();
            this.dShow_option = new System.Windows.Forms.ComboBox();
            this.choose_option = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.sendURL = new System.Windows.Forms.TextBox();
            this.getCommend = new System.Windows.Forms.Button();
            this.startLive = new System.Windows.Forms.Button();
            this.stopLive = new System.Windows.Forms.Button();
            this.liveState = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tip
            // 
            this.tip.Enabled = false;
            this.tip.Location = new System.Drawing.Point(140, 182);
            this.tip.Multiline = true;
            this.tip.Name = "tip";
            this.tip.ReadOnly = true;
            this.tip.Size = new System.Drawing.Size(156, 130);
            this.tip.TabIndex = 0;
            // 
            // choose_dShow
            // 
            this.choose_dShow.Location = new System.Drawing.Point(33, 30);
            this.choose_dShow.Name = "choose_dShow";
            this.choose_dShow.Size = new System.Drawing.Size(75, 23);
            this.choose_dShow.TabIndex = 1;
            this.choose_dShow.Text = "选择设备";
            this.choose_dShow.UseVisualStyleBackColor = true;
            this.choose_dShow.Click += new System.EventHandler(this.button1_Click);
            // 
            // dShow_Name
            // 
            this.dShow_Name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dShow_Name.Enabled = false;
            this.dShow_Name.FormattingEnabled = true;
            this.dShow_Name.Location = new System.Drawing.Point(149, 30);
            this.dShow_Name.Name = "dShow_Name";
            this.dShow_Name.Size = new System.Drawing.Size(121, 20);
            this.dShow_Name.TabIndex = 2;
            this.dShow_Name.SelectedIndexChanged += new System.EventHandler(this.dShow_Name_SelectedIndexChanged);
            // 
            // dShow_option
            // 
            this.dShow_option.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dShow_option.Enabled = false;
            this.dShow_option.FormattingEnabled = true;
            this.dShow_option.Location = new System.Drawing.Point(149, 81);
            this.dShow_option.Name = "dShow_option";
            this.dShow_option.Size = new System.Drawing.Size(121, 20);
            this.dShow_option.TabIndex = 3;
            // 
            // choose_option
            // 
            this.choose_option.Enabled = false;
            this.choose_option.Location = new System.Drawing.Point(33, 79);
            this.choose_option.Name = "choose_option";
            this.choose_option.Size = new System.Drawing.Size(75, 23);
            this.choose_option.TabIndex = 4;
            this.choose_option.Text = "选择格式";
            this.choose_option.UseVisualStyleBackColor = true;
            this.choose_option.Click += new System.EventHandler(this.chance_option_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "推送地址：";
            // 
            // sendURL
            // 
            this.sendURL.Location = new System.Drawing.Point(102, 127);
            this.sendURL.Name = "sendURL";
            this.sendURL.Size = new System.Drawing.Size(184, 21);
            this.sendURL.TabIndex = 6;
            // 
            // getCommend
            // 
            this.getCommend.Location = new System.Drawing.Point(33, 180);
            this.getCommend.Name = "getCommend";
            this.getCommend.Size = new System.Drawing.Size(75, 23);
            this.getCommend.TabIndex = 7;
            this.getCommend.Text = "获得命令";
            this.getCommend.UseVisualStyleBackColor = true;
            this.getCommend.Click += new System.EventHandler(this.getCommend_Click);
            // 
            // startLive
            // 
            this.startLive.Location = new System.Drawing.Point(33, 232);
            this.startLive.Name = "startLive";
            this.startLive.Size = new System.Drawing.Size(75, 23);
            this.startLive.TabIndex = 8;
            this.startLive.Text = "开始直播";
            this.startLive.UseVisualStyleBackColor = true;
            this.startLive.Click += new System.EventHandler(this.startLive_Click);
            // 
            // stopLive
            // 
            this.stopLive.Location = new System.Drawing.Point(33, 278);
            this.stopLive.Name = "stopLive";
            this.stopLive.Size = new System.Drawing.Size(75, 23);
            this.stopLive.TabIndex = 9;
            this.stopLive.Text = "关闭直播";
            this.stopLive.UseVisualStyleBackColor = true;
            this.stopLive.Click += new System.EventHandler(this.stopLive_Click);
            // 
            // liveState
            // 
            this.liveState.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.liveState.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.liveState.Location = new System.Drawing.Point(33, 330);
            this.liveState.Name = "liveState";
            this.liveState.ReadOnly = true;
            this.liveState.Size = new System.Drawing.Size(263, 14);
            this.liveState.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(334, 363);
            this.Controls.Add(this.liveState);
            this.Controls.Add(this.stopLive);
            this.Controls.Add(this.startLive);
            this.Controls.Add(this.getCommend);
            this.Controls.Add(this.sendURL);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.choose_option);
            this.Controls.Add(this.dShow_option);
            this.Controls.Add(this.dShow_Name);
            this.Controls.Add(this.choose_dShow);
            this.Controls.Add(this.tip);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tip;
        private System.Windows.Forms.Button choose_dShow;
        private System.Windows.Forms.ComboBox dShow_Name;
        private System.Windows.Forms.ComboBox dShow_option;
        private System.Windows.Forms.Button choose_option;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox sendURL;
        private System.Windows.Forms.Button getCommend;
        private System.Windows.Forms.Button startLive;
        private System.Windows.Forms.Button stopLive;
        private System.Windows.Forms.TextBox liveState;
    }
}

