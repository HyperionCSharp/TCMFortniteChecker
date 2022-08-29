using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Threading;

/// <summary>
/// Protection for your assembly
/// </summary>
/// <author>
/// gigajew
/// </author>
sealed class Anti
{
    [DllImport("kernel32.dll", CharSet = CharSet.Ansi)]
    static extern IntPtr LoadLibraryA([MarshalAs(UnmanagedType.LPStr)] string library);
    [DllImport("user32.dll")]
    public static extern bool InternetSetOption(IntPtr hInternet, int dwOption, IntPtr lpBuffer, int dwBufferLength);
    public const int INTERNET_OPTION_SETTINGS_CHANGED = 39;
    public const int INTERNET_OPTION_REFRESH = 37;
    public static bool settingsReturn, refreshReturn;

    /// <summary>
    /// Man handle the timeout in threads to save CPU (default 100)
    /// </summary>
    public int Timeout
    {
        get { return _timeout; }
        set { _timeout = value; }
    }

    /// <summary>
    /// Define what process names are not allowed
    /// </summary>
    public string[] Snoopers
    {
        get { return _snoopers; }
        set { _snoopers = value; }
    }

    /// <summary>
    /// Constructor
    /// </summary>
    public Anti()
    {
        _random = new Random(Guid.NewGuid().GetHashCode());

        _snoopers = new string[] { "wireshark", "dnspy", "ilspy", "fiddler", "fiddler4" };

        //_debuggerFlag = new ManualResetEvent(false);
        _snooperFlag = new ManualResetEvent(false);

        //_debuggerFlag.Reset();
        _snooperFlag.Reset();

        _timeout = 100;
    }

    /// <summary>
    /// Start protecting this assembly
    /// </summary>
    public void Start()
    {
        if (_running)
            return;

        _running = true;

        // initial protections
        //AntiEmulation();

        // continous protections
        //if (_debuggerThread == null)
            //_debuggerThread = new Thread(AntiDebug);

        if (_snooperThread == null)
            _snooperThread = new Thread(AntiSnoop);


        //_debuggerThread.IsBackground = true;
        _snooperThread.IsBackground = true;

        //_debuggerThread.Start();
        _snooperThread.Start();

        // wait for initial execution
        //_debuggerFlag.WaitOne();
        _snooperFlag.WaitOne();
    }

    /// <summary>
    /// Stop protecting this assembly
    /// </summary>
    public void Stop()
    {
        if (!_running)
            return;

        _running = false;

        //_debuggerThread.Abort();
        _snooperThread.Abort();
    }

    /// <summary>
    /// Anti emulation techniques
    /// </summary>

    /// <summary>
    /// Anti module injection techniques
    /// </summary>

    /// <summary>
    /// Anti snoop techniques
    /// </summary>
    private void AntiSnoop()
    {
        while (_running)
        {
            DisableProxySettings();
            CheckForFiddler();
            CheckForAnyProxyConnections();
            for (int i = 0; i < Snoopers.Length; i++)
            {
                KillProcessByWindowTitle(Snoopers[i], false);
            }
            _snooperFlag.Set();
            Thread.Sleep(Timeout);
        }
    }
    private static void DisableProxySettings()
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

        }
    }

    private void CheckForAnyProxyConnections()
    {
        try
        {
            RegistryKey registry = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings", true);
            string ProxyEnabledOrNuh = registry.GetValue("ProxyEnable").ToString();
            object ProxyServerValue = registry.GetValue("ProxyServer");
            if (ProxyEnabledOrNuh == "1")
            {
                Process.GetCurrentProcess().Kill();
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
    }
    private void CheckForFiddler()
    {
        if (LoadLibraryA("FiddlerCore4.dll") != IntPtr.Zero || LoadLibraryA("RestSharp.dll") != IntPtr.Zero || LoadLibraryA("Titanium.Web.Proxy.dll") != IntPtr.Zero)
        {
            Process.GetCurrentProcess().Kill();
        }
    }

    public void KillProcessByWindowTitle(string title, bool caseSensitive)

    {
        Process[] myPSList = Process.GetProcesses();

        foreach (Process p in myPSList)
        {

            if (caseSensitive)
            {
                if (p.MainWindowTitle.Contains(title))
                {
                    p.Kill();
                }
            }
            else
            {
                string mainWindowTitle = p.MainWindowTitle;
                mainWindowTitle = mainWindowTitle.ToLower();
                title = title.ToLower();

                if (mainWindowTitle.Contains(title))
                {
                    p.Kill();
                }
            }
        }
    }

    //private Thread _debuggerThread;
    private Thread _snooperThread;
    private Thread _UpdateThread;
    private ManualResetEvent _debuggerFlag;
    private ManualResetEvent _snooperFlag;
    private Random _random;
    private int _timeout;
    private string[] _snoopers;
    private bool _running;
}