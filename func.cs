using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.IO.Compression;

namespace JDK_packageConvert
{
    class func
    {

        public static string cmd(String command)               
        {
            Process p = new Process();
            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.UseShellExecute = false;                  
            p.StartInfo.RedirectStandardInput = true;             
            p.StartInfo.RedirectStandardOutput = true;            
            p.StartInfo.CreateNoWindow = true;                    
            p.Start();
            p.StandardInput.WriteLine(command);
            //p.WaitForExit();
            p.StandardInput.WriteLine("exit");
            string s = p.StandardOutput.ReadToEnd();
            p.Close();
            return s;
        }

        public static bool IsAdministrator()
        {
            WindowsIdentity current = WindowsIdentity.GetCurrent();
            WindowsPrincipal windowsPrincipal = new WindowsPrincipal(current);
            //WindowsBuiltInRole可以枚举出很多权限，例如系统用户、User、Guest等等  
            return windowsPrincipal.IsInRole(WindowsBuiltInRole.Administrator);
        }

        public static bool checkDir(string path) 
        {
            if (File.Exists(path + "\\.rsrc\\1033\\JAVA_CAB10\\111"))
            {
                return true;
            }
            else return false;
        }

        public static void ExtractTools(FileInfo tools) {
            try
            {
                ZipFile.ExtractToDirectory(tools.FullName, tools.DirectoryName + "/JDK");
                File.Delete(tools.FullName);
            }
            catch (Exception e)
            {

                throw e;
            }
        }
    }
}
