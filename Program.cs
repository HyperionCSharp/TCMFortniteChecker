using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCM_Fortnite_Tool
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        [DllImport("user32.dll")]
        public static extern bool InternetSetOption(IntPtr hInternet, int dwOption, IntPtr lpBuffer, int dwBufferLength);
        public const int INTERNET_OPTION_SETTINGS_CHANGED = 39;
        public const int INTERNET_OPTION_REFRESH = 37;
        public static bool settingsReturn, refreshReturn;

        [STAThread]

        static void Main()
        {
            try
            {
                RegistryKey registry = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings", true);
                string ProxyEnabledOrNuh = registry.GetValue("ProxyEnable").ToString();
                object ProxyServerValue = registry.GetValue("ProxyServer");
                if (ProxyEnabledOrNuh == "1")
                {
                        try
                        {
                            RegistryKey RegKey = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings", true);
                            RegKey.SetValue("ProxyServer", 0);
                            RegKey.SetValue("ProxyEnable", 0);

                            // These lines implement the Interface in the beginning of program 
                            // They cause the OS to refresh the settings, causing IP to realy update
                            settingsReturn = InternetSetOption(IntPtr.Zero, INTERNET_OPTION_SETTINGS_CHANGED, IntPtr.Zero, 0);
                            refreshReturn = InternetSetOption(IntPtr.Zero, INTERNET_OPTION_REFRESH, IntPtr.Zero, 0);
                    }
                    catch
                    {
                        Process.GetCurrentProcess().Kill();
                    }
                }
            }
            catch
            {

            }
            try
            {           
                string FileContent = File.ReadAllText(@"C:\WINDOWS\System32\Drivers\Etc\hosts");      
                if (FileContent.Contains("tcmtools.com") || FileContent.Contains("Gamersocial.co") || FileContent.Contains("tcm.tools"))
                {
                    Process.GetCurrentProcess().Kill();
                }
            }
            catch
            {
                
            }
            try
            {
                string CurrentDirectory = System.IO.Directory.GetCurrentDirectory();
                if (CurrentDirectory.Contains("AppData\\Local\\Temp"))
                {
                    MessageBox.Show("Pleas Extract All Files To A Folder Then Run The Program");
                    Process.GetCurrentProcess().Kill();
                }
            }
            catch
            {

            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
