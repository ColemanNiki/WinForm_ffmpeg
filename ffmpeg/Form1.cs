﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace ffmpeg
{
    public partial class Form1 : Form
    {
        cmdProcess liveP;
        bool liveReady = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            all_in_check.CheckState = CheckState.Checked;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmdProcess p = new cmdProcess();
            string arguments = "-list_devices true -f dshow -i dummy";
            p.InitP(arguments);
            p.ErrorDataReceived += new DataReceivedEventHandler(dShow_Append);
            p.Start();//启动线程
            p.BeginErrorReadLine();//开始异步读取
            p.WaitForExit();//阻塞等待进程结束
            p.Close();//关闭进程
            p.Dispose();
        }

        private void dShow_Append(object sendProcess,DataReceivedEventArgs output)
        {
            if (!String.IsNullOrEmpty(output.Data)) {
                string pattern = "(?<=(\\[dshow.*\\]\\s+\")).*(?=\")";
                Match match = Regex.Match(output.Data, @pattern);
                if (match.Success)
                {
                    dShow_Name.Items.Add(match.Value);
                }
                dShow_Name.Enabled = true;
            }
        }

        private void chance_option_Click(object sender, EventArgs e)
        {
            cmdProcess p = new cmdProcess();
            string arguments = "-list_options true -f dshow -i video=\"" + dShow_Name.Text + "\"";
            p.InitP(arguments);
            p.ErrorDataReceived += new DataReceivedEventHandler(option_Append);
            p.Start();
            p.BeginErrorReadLine();
            p.WaitForExit();
            p.Close();
            p.Dispose();
        }

        private void option_Append(object sendProcess,DataReceivedEventArgs output)
        {
            if (!String.IsNullOrEmpty(output.Data))
            {
                string pattern = "s=.+?fps=\\d+";
                MatchCollection matches = Regex.Matches(output.Data, pattern);
                foreach(Match match in matches)
                {
                    dShow_option.Items.Add(match.Value);
                }
                dShow_option.Enabled = true;
            }
        }

        private void getCommend_Click(object sender, EventArgs e)
        {
                string url = sendURL.Text;
                bool isUrl = Regex.IsMatch(url, @"https?://");
                if (isUrl)
                {
                    if (carema_check.CheckState == CheckState.Checked)
                    {
                        Match match = Regex.Match(dShow_option.Text, "(?<=(fps=))\\d+");
                        string fps = match.Value;
                        Console.WriteLine(fps);
                        match = Regex.Match(dShow_option.Text, "(?<=(s=))\\d+x\\d+");
                        string size = match.Value;
                        string commend = "-f dshow -framerate " + fps + " -video_size " + size + " -i video=\"" + dShow_Name.Text + "\""
                            + " -f mpegts -codec:v mpeg1video -s 1000x600 -b:v "+ bitSize.Text + "k -bf 0 \"" + url + "\"";
                        tip.Text = commend;
                        liveReady = true;
                    }
                    else if(all_in_check.CheckState == CheckState.Checked)
                    {
                        string commend = "-f gdigrab -framerate 30 -i desktop " + " -f mpegts   -codec:v mpeg1video -preset ultrafast -crf 1 -s 1000x600 -b:v " 
                            + bitSize.Text + "k -bf 0 \"" + url + "\"";
                        tip.Text = commend;
                        liveReady = true;
                    }
                    else
                    {
                        string commend = "-i "+local_file.Text+ " -f mpegts -codec:v mpeg1video -preset ultrafast -crf 1 -s 1000x600 -b:v " 
                                + bitSize.Text + "k -bf 0 \"" + url + "\"";
                        tip.Text = commend;
                        liveReady = true;
                    }
                }
                else
                {
                    tip.Text = "url设置不正确";
                }
        }

        private void startLive_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tip.Text) && liveReady)
            {
                liveP = new cmdProcess();
                Console.WriteLine(tip.Text);
                liveP.InitP(tip.Text);
                liveP.Start();
                liveP.ErrorDataReceived += new DataReceivedEventHandler(show_liveState);
                liveP.BeginErrorReadLine();
            }
            else
            {
                tip.Text = "请先设置好参数";
            }
        }

        private void stopLive_Click(object sender, EventArgs e)
        {
            foreach(Process p in Process.GetProcessesByName("ffmpeg"))
            {
                try
                {
                    p.Kill();
                    p.WaitForExit();
                    p.Dispose();
                }
                catch(Exception exp)
                {
                    Console.WriteLine(exp.Message);
                    Console.WriteLine("该进程无法杀死");
                }
            }
        }

        private void show_liveState(object sendProcess, DataReceivedEventArgs output)
        {
            if (!String.IsNullOrEmpty(output.Data))
            {
                string pattern = "fps.*/s";
                if (Regex.IsMatch(output.Data, pattern))
                {
                    Console.WriteLine(output.Data);
                    string fps = Regex.Match(output.Data, "(?<=(fps=\\s)).*?(?=\\s)").Value;
                    string time = Regex.Match(output.Data, "(?<=(time=)).*?(?=\\.)").Value;
                    string bitrate = Regex.Match(output.Data, "(?<=(bitrate=\\s)).*?(?=\\s)").Value;
                    string stateTip = "fps:" + fps + "  time:" + time + " bitrate:" + bitrate;
                    liveState.Text = stateTip;
                }
            }
        }

        private void dShow_Name_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(dShow_Name.Text))
            {
                choose_option.Enabled = true;
            }
        }

        private void all_in_check_CheckedChanged(object sender, EventArgs e)
        {
            if(all_in_check.CheckState == CheckState.Checked)
            {
                local_check_box.CheckState = CheckState.Unchecked;
                carema_check.CheckState = CheckState.Unchecked;
                choose_dShow.Enabled = false;
            }
        }

        private void local_check_box_CheckedChanged(object sender, EventArgs e)
        {
            if(local_check_box.CheckState == CheckState.Checked)
            {
                all_in_check.CheckState = CheckState.Unchecked;
                carema_check.CheckState = CheckState.Unchecked;
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Multiselect = false;
                dialog.Title = "请选择视频文件";
                if(dialog.ShowDialog() == DialogResult.OK)
                {
                    local_file.Text = dialog.FileName;
                }
            }
        }

        private void carema_check_CheckedChanged(object sender, EventArgs e)
        {
            if(carema_check.CheckState == CheckState.Checked)
            {
                all_in_check.CheckState = CheckState.Unchecked;
                local_check_box.CheckState = CheckState.Unchecked;
                choose_dShow.Enabled = true;
            }
        }
    }
}