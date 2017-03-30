using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ffmpeg
{
    class cmdProcess:Process
    {
        public void InitP(string arguments)
        {
            string str1 = Environment.CurrentDirectory;
            str1 += @"\ffmpeg\bin\ffmpeg.exe";
            Console.WriteLine(str1);
            this.StartInfo.FileName = @str1;//要调用外部程序的绝对路径
            this.StartInfo.UseShellExecute = false;//不使用操作系统外壳程序启动线程(一定为FALSE,详细的请看MSDN)
            this.StartInfo.RedirectStandardError = true;
            this.StartInfo.CreateNoWindow = true;//不创建进程窗口
            this.StartInfo.Arguments = @arguments; //添加参数
        }
    }
}
