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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            this.all_in_check = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bitSize = new System.Windows.Forms.TextBox();
            this.local_check_box = new System.Windows.Forms.CheckBox();
            this.carema_check = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.local_file = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tip
            // 
            this.tip.Location = new System.Drawing.Point(148, 283);
            this.tip.Multiline = true;
            this.tip.Name = "tip";
            this.tip.ReadOnly = true;
            this.tip.Size = new System.Drawing.Size(156, 130);
            this.tip.TabIndex = 0;
            // 
            // choose_dShow
            // 
            this.choose_dShow.Enabled = false;
            this.choose_dShow.Location = new System.Drawing.Point(33, 100);
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
            this.dShow_Name.Location = new System.Drawing.Point(148, 100);
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
            this.dShow_option.Location = new System.Drawing.Point(148, 132);
            this.dShow_option.Name = "dShow_option";
            this.dShow_option.Size = new System.Drawing.Size(121, 20);
            this.dShow_option.TabIndex = 3;
            // 
            // choose_option
            // 
            this.choose_option.Enabled = false;
            this.choose_option.Location = new System.Drawing.Point(33, 129);
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
            this.label1.Location = new System.Drawing.Point(34, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "推送地址：";
            // 
            // sendURL
            // 
            this.sendURL.Location = new System.Drawing.Point(148, 207);
            this.sendURL.Name = "sendURL";
            this.sendURL.Size = new System.Drawing.Size(133, 21);
            this.sendURL.TabIndex = 6;
            // 
            // getCommend
            // 
            this.getCommend.Location = new System.Drawing.Point(33, 271);
            this.getCommend.Name = "getCommend";
            this.getCommend.Size = new System.Drawing.Size(75, 23);
            this.getCommend.TabIndex = 7;
            this.getCommend.Text = "获得命令";
            this.getCommend.UseVisualStyleBackColor = true;
            this.getCommend.Click += new System.EventHandler(this.getCommend_Click);
            // 
            // startLive
            // 
            this.startLive.Location = new System.Drawing.Point(33, 331);
            this.startLive.Name = "startLive";
            this.startLive.Size = new System.Drawing.Size(75, 23);
            this.startLive.TabIndex = 8;
            this.startLive.Text = "开始直播";
            this.startLive.UseVisualStyleBackColor = true;
            this.startLive.Click += new System.EventHandler(this.startLive_Click);
            // 
            // stopLive
            // 
            this.stopLive.Location = new System.Drawing.Point(33, 390);
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
            this.liveState.Location = new System.Drawing.Point(33, 439);
            this.liveState.Name = "liveState";
            this.liveState.ReadOnly = true;
            this.liveState.Size = new System.Drawing.Size(357, 14);
            this.liveState.TabIndex = 10;
            // 
            // all_in_check
            // 
            this.all_in_check.AutoSize = true;
            this.all_in_check.Checked = true;
            this.all_in_check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.all_in_check.Location = new System.Drawing.Point(36, 29);
            this.all_in_check.Name = "all_in_check";
            this.all_in_check.Size = new System.Drawing.Size(72, 16);
            this.all_in_check.TabIndex = 11;
            this.all_in_check.Text = "全屏直播";
            this.all_in_check.UseVisualStyleBackColor = true;
            this.all_in_check.CheckedChanged += new System.EventHandler(this.all_in_check_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 12);
            this.label2.TabIndex = 12;
            this.label2.Text = "输入推送质量（建议500）";
            // 
            // bitSize
            // 
            this.bitSize.Location = new System.Drawing.Point(183, 65);
            this.bitSize.Name = "bitSize";
            this.bitSize.Size = new System.Drawing.Size(60, 21);
            this.bitSize.TabIndex = 13;
            this.bitSize.Text = "500";
            this.bitSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // local_check_box
            // 
            this.local_check_box.AutoSize = true;
            this.local_check_box.Location = new System.Drawing.Point(132, 29);
            this.local_check_box.Name = "local_check_box";
            this.local_check_box.Size = new System.Drawing.Size(96, 16);
            this.local_check_box.TabIndex = 14;
            this.local_check_box.Text = "推送本地文件";
            this.local_check_box.UseVisualStyleBackColor = true;
            this.local_check_box.CheckedChanged += new System.EventHandler(this.local_check_box_CheckedChanged);
            // 
            // carema_check
            // 
            this.carema_check.AutoSize = true;
            this.carema_check.Location = new System.Drawing.Point(253, 29);
            this.carema_check.Name = "carema_check";
            this.carema_check.Size = new System.Drawing.Size(84, 16);
            this.carema_check.TabIndex = 15;
            this.carema_check.Text = "推送摄像头";
            this.carema_check.UseVisualStyleBackColor = true;
            this.carema_check.CheckedChanged += new System.EventHandler(this.carema_check_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 16;
            this.label3.Text = "本地文件：";
            // 
            // local_file
            // 
            this.local_file.Location = new System.Drawing.Point(148, 174);
            this.local_file.Name = "local_file";
            this.local_file.ReadOnly = true;
            this.local_file.Size = new System.Drawing.Size(133, 21);
            this.local_file.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(362, 465);
            this.Controls.Add(this.local_file);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.carema_check);
            this.Controls.Add(this.local_check_box);
            this.Controls.Add(this.bitSize);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.all_in_check);
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
            this.DoubleBuffered = true;
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
        private System.Windows.Forms.CheckBox all_in_check;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox bitSize;
        private System.Windows.Forms.CheckBox local_check_box;
        private System.Windows.Forms.CheckBox carema_check;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox local_file;
    }
}

