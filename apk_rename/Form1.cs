using apk_rename.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace apk_rename
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = Settings.Default.platform_tools;
        }

        private void btSelectFold_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.FolderBrowserDialog dialog = new System.Windows.Forms.FolderBrowserDialog();
            dialog.Description = "请选择Txt所在文件夹";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (string.IsNullOrEmpty(dialog.SelectedPath))
                {
                    MessageBox.Show(this, "文件夹路径不能为空", "提示");
                    return;
                }
                textBox1.Text = dialog.SelectedPath;
                Settings.Default.platform_tools = dialog.SelectedPath;
                Settings.Default.Save();
                //a.BeginInvoke(dialog.SelectedPath, asyncCallback, a);
            }
        }

        private void btSelectFiles_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();

            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = true;//该值确定是否可以选择多个文件
            dialog.Title = "请选择apk";
            dialog.Filter = "apk文件(*.apk)|*.apk";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                foreach (var name in dialog.FileNames)
                    listView1.Items.Add(new ListViewItem { Text = name });
            }
        }

        private void btRun_Click(object sender, EventArgs e)
        {
            int nnn = 1;
            richTextBox1.Text = "";
            richTextBox2.Text = "";
            Debug.WriteLine("Count="+listView1.Items.Count);
            //listView1.Items.Add(new ListViewItem { Text = @"D:\doubl\OneDrive - alumni.npust.edu.tw\apk\@丹江\allapk1\aaa.apk"});
            foreach (ListViewItem item in listView1.Items)
            {
                Debug.WriteLine(String.Format("{0}/{1}", nnn++, listView1.Items.Count));
                string apk = item.Text;
                //进程的名称
                string fileName = textBox1.Text + "\\aapt.exe";
                //测试参数
                string para = " dump badging \"" + apk + "\"";

                //声明
                Process p = new Process();

                p.StartInfo.CreateNoWindow = true;         // 不创建新窗口    
                p.StartInfo.UseShellExecute = false;       //不启用shell启动进程  
                p.StartInfo.RedirectStandardInput = true;  // 重定向输入    
                p.StartInfo.RedirectStandardOutput = true; // 重定向标准输出    
                p.StartInfo.RedirectStandardError = true;  // 重定向错误输出  
                p.StartInfo.FileName = fileName;
                p.StartInfo.Arguments = para;
                p.StartInfo.StandardOutputEncoding = Encoding.UTF8;

                p.Start();

                //p.StandardInput.WriteLine(para);
                p.StandardInput.AutoFlush = true;
                p.StandardInput.Close();

                string output = p.StandardOutput.ReadToEnd();

                //  p.OutputDataReceived += new DataReceivedEventHandler(processOutputDataReceived);
                p.WaitForExit();//参数单位毫秒，在指定时间内没有执行完则强制结束，不填写则无限等待
                p.Close();

                richTextBox1.Text += output;

                string pack = FindSting(output, "package: name='");
                string name;
                name = FindSting(output, "application-label-zh-CN:'");
                if (name == null)
                    name = FindSting(output, "application-label-zh:'");
                if (name == null)
                    name = FindSting(output, "application-label:'");
                if (name == null)
                {
                    //Debugger.Break();
                    name = "";
                }

                byte[] b = Encoding.Unicode.GetBytes(name);

                name = name.Replace('/', ' ');
                name = name.Trim(' ');
                name = name.Trim('\n');
                name = name.Replace(Char.ConvertFromUtf32(0xa0), "");
                name = name.Replace(Char.ConvertFromUtf32(0x200b), "");

                string ver = FindSting(output, "versionName='");
                string versionCode = FindSting(output, "versionCode='");

                String newapk = String.Format("{0}_{1}_{2}({3}).apk", name, pack, ver, versionCode);
                if (true)
                {
                    if (name != null && name.Length > -1 && newapk.CompareTo(Path.GetFileName(apk)) != 0)
                    {
                        richTextBox2.Text += String.Format("ren \"{0}\" \"{1}\"\n", apk, newapk);
                    }
                }
                else
                {
                    if (newapk.CompareTo(Path.GetFileName(apk)) == 0)
                    {
                        richTextBox2.Text += String.Format("move \"{0}\" \n", apk);
                    }
                }


            }
        }
        private string FindSting(string s, string h, string t = "'")
        {
            int n1 = s.IndexOf(h);
            if (n1 < 0)
            {
                return null;
            }
            n1 += h.Length;
            int n2 = s.IndexOf(t, n1);
            string s2 = s.Substring(n1, n2 - n1);
            return s2;
        }
    }
}
