using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JDK_packageConvert
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (func.IsAdministrator())
            {
                tssl_role.ForeColor = Color.Green;
                tssl_role.Text = "管理员权限";
            }
            else
            {
                tssl_role.ForeColor = Color.Red;
                tssl_role.Text = "非管理员权限";
            }
        }

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Link;
            else e.Effect = DragDropEffects.None;
        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            string path = ((System.Array)e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();
            lb_notify.Text = "处理中....";
            ParameterizedThreadStart pts = new ParameterizedThreadStart(run);
            Thread td = new Thread(pts);
            td.Start(path);
        }

        private  void run(object opath) {
            string path = (string)opath;
            if (func.checkDir(path))
            {
                try
                {
                    FileInfo info = new FileInfo(path);
                    string DirectoryName = info.DirectoryName;
                    string RootPath = DirectoryName.Split(':')[0];

                    func.cmd("extrac32 " + path + "/.rsrc/1033/JAVA_CAB10/111");
                    Thread.Sleep(2000);

                    int i = 0;
                    while (!File.Exists("tools.zip")) {
                        Thread.Sleep(10);
                        i++;
                        if (i > 500) {
                            break;
                        }
                    }

                    if (File.Exists("tools.zip"))
                    {
                        lb_notify.Text = "请坐和放宽,完成后会自动退出!";
                        func.ExtractTools(new FileInfo("tools.zip"));

                        string MovedCommand = "cd JDK";
                        string Command = "for /r %x in (*.pack) do .\\bin\\unpack200 -r \"%x\" \"%~dx%~px%~nx.jar";
                        func.cmd(MovedCommand + " && " + Command);
                        
                        
                        Environment.Exit(0);
                    }
                    else
                    {
                        MessageBox.Show("未生成所需内容！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Environment.Exit(0);
                    }
                }
                catch (Exception e)
                {

                    MessageBox.Show(e.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Environment.Exit(0);
                }
                

            }
            else {

                MessageBox.Show("所选内容无效", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
