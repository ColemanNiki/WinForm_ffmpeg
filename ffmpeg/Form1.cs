using System;
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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //cmdProcess p = new cmdProcess();
            //string value = p.write("ffmpeg");  
            //this.tip.Text = value;
            Control.CheckForIllegalCrossThreadCalls = false;
            //str1 = Environment.CurrentDirectory;
            //str1 += @"\ffmpeg\bin\ffmpeg.exe";
            //p.StartInfo.FileName = @str1;//要调用外部程序的绝对路径
            //p.StartInfo.UseShellExecute = false;//不使用操作系统外壳程序启动线程(一定为FALSE,详细的请看MSDN)
            //p.StartInfo.RedirectStandardError = true;
            //p.StartInfo.CreateNoWindow = true;//不创建进程窗口
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
                    dShowName.Items.Add(match.Value);
                }
            }
        }

        private void chance_option_Click(object sender, EventArgs e)
        {
            cmdProcess p = new cmdProcess();
            string arguments = "-list_options true -f dshow -i video=\"" + dShowName.Text + "\"";
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
                string pattern = "s=.+fps=\\d+";
                MatchCollection matches = Regex.Matches(output.Data, pattern);
                foreach(Match match in matches)
                {
                    dShow_option.Items.Add(match.Value);
                }
            }
        }
    }
}