using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Microsoft.VisualBasic.ApplicationServices
{
    public enum AuthenticationMode
    {
        Windows,
        ApplicationDefined
    }

    public enum ShutdownMode
    {
        AfterMainFormCloses,
        AfterAllFormsClose
    }

    // Base class — placeholder for WindowsFormsApplicationBase (not implemented fully here)
    public class WindowsFormsApplicationBase
    {
        public bool IsSingleInstance { get; set; }
        public bool EnableVisualStyles { get; set; }
        public bool SaveMySettingsOnExit { get; set; }
        public ShutdownMode ShutdownStyle { get; set; }

        protected Form MainForm { get; set; }

        public WindowsFormsApplicationBase()
        {
        }

        public WindowsFormsApplicationBase(AuthenticationMode authenticationMode)
        {
        }

        protected virtual void OnCreateMainForm()
        {
        }

        public virtual void Run(string[] args)
        {
            if (EnableVisualStyles)
                Application.EnableVisualStyles();

            Application.SetCompatibleTextRenderingDefault(false);
            OnCreateMainForm();

            if (MainForm != null)
                Application.Run(MainForm);
        }

        private MyApplicationInfo _info;
        public MyApplicationInfo Info => _info ?? (_info = new MyApplicationInfo());
    }

    public class MyApplicationInfo
    {
        private readonly Assembly _assembly = Assembly.GetEntryAssembly() ?? Assembly.GetCallingAssembly();

        public string Title =>
            ((AssemblyTitleAttribute)Attribute.GetCustomAttribute(_assembly, typeof(AssemblyTitleAttribute)))
            ?.Title ?? string.Empty;

        public string Description =>
            ((AssemblyDescriptionAttribute)Attribute.GetCustomAttribute(_assembly, typeof(AssemblyDescriptionAttribute)))
            ?.Description ?? string.Empty;

        public string CompanyName =>
            ((AssemblyCompanyAttribute)Attribute.GetCustomAttribute(_assembly, typeof(AssemblyCompanyAttribute)))
            ?.Company ?? string.Empty;

        public string ProductName =>
            ((AssemblyProductAttribute)Attribute.GetCustomAttribute(_assembly, typeof(AssemblyProductAttribute)))
            ?.Product ?? string.Empty;

        public string Copyright =>
            ((AssemblyCopyrightAttribute)Attribute.GetCustomAttribute(_assembly, typeof(AssemblyCopyrightAttribute)))
            ?.Copyright ?? string.Empty;

        public string Trademark =>
            ((AssemblyTrademarkAttribute)Attribute.GetCustomAttribute(_assembly, typeof(AssemblyTrademarkAttribute)))
            ?.Trademark ?? string.Empty;

        public Version Version => _assembly.GetName().Version;

        public string DirectoryPath => AppDomain.CurrentDomain.BaseDirectory;

        public string AssemblyName => _assembly.GetName().Name;
    }

    // Placeholder for Microsoft.VisualBasic.ApplicationServices.User
    public class User
    {
        public System.Security.Principal.IPrincipal CurrentPrincipal
        {
            get => System.Threading.Thread.CurrentPrincipal;
            set => System.Threading.Thread.CurrentPrincipal = value;
        }

        public System.Security.Principal.IIdentity CurrentUser =>
            System.Threading.Thread.CurrentPrincipal?.Identity;

        public string Name =>
            System.Threading.Thread.CurrentPrincipal?.Identity?.Name ?? string.Empty;

        public bool IsInRole(string role) =>
            System.Threading.Thread.CurrentPrincipal?.IsInRole(role) ?? false;

        public bool IsAuthenticated =>
            System.Threading.Thread.CurrentPrincipal?.Identity?.IsAuthenticated ?? false;
    }

    public class UnhandledExceptionEventArgs : EventArgs
    {
        public Exception Exception { get; }
        public bool ExitApplication { get; set; } = true;

        public UnhandledExceptionEventArgs(Exception ex)
        {
            Exception = ex;
        }
    }
}

namespace SBuilderXX.My
{
    public class MyScreen
    {
        // Returns the primary monitor
        public System.Drawing.Rectangle Bounds =>
            System.Windows.Forms.Screen.PrimaryScreen.Bounds;

        public System.Drawing.Rectangle WorkingArea =>
            System.Windows.Forms.Screen.PrimaryScreen.WorkingArea;

        public int Width => System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width;
        public int Height => System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height;
    }

    public class MyRegistry
    {
        public object GetValue(string keyName, string valueName, object defaultValue) =>
            Microsoft.Win32.Registry.GetValue(keyName, valueName, defaultValue);

        public void SetValue(string keyName, string valueName, object value) =>
            Microsoft.Win32.Registry.SetValue(keyName, valueName, value);

        public Microsoft.Win32.RegistryKey CurrentUser =>
            Microsoft.Win32.Registry.CurrentUser;

        public Microsoft.Win32.RegistryKey LocalMachine =>
            Microsoft.Win32.Registry.LocalMachine;

        public Microsoft.Win32.RegistryKey ClassesRoot =>
            Microsoft.Win32.Registry.ClassesRoot;

        public Microsoft.Win32.RegistryKey GetValue_Raw(string keyName, string valueName, object defaultValue) =>
            throw new NotImplementedException();

        public Microsoft.Win32.RegistryKey Users => Microsoft.Win32.Registry.Users;
        public Microsoft.Win32.RegistryKey CurrentConfig => Microsoft.Win32.Registry.CurrentConfig;
    }
}