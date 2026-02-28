// Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

using Microsoft.Win32;
using System;
using System.Collections;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Threading;
using System.Windows.Forms;

namespace SBuilderXX.My
{
    [System.CodeDom.Compiler.GeneratedCode("MyTemplate", "11.0.0.0")]
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    internal partial class MyApplication : Microsoft.VisualBasic.ApplicationServices.WindowsFormsApplicationBase
    {
        [STAThread()]
        [DebuggerHidden()]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static void Main(string[] args)
        {
            MyProject.Application.Run(args);
        }

        public event EventHandler<Microsoft.VisualBasic.ApplicationServices.UnhandledExceptionEventArgs> UnhandledException;

        internal void RaiseUnhandledException(Microsoft.VisualBasic.ApplicationServices.UnhandledExceptionEventArgs e)
        {
            UnhandledException?.Invoke(this, e);
        }
    }

    namespace ApplicationServices
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

    [System.CodeDom.Compiler.GeneratedCode("MyTemplate", "11.0.0.0")]
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    internal partial class MyComputer
    {
        [DebuggerHidden()]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public MyComputer()
        {
        }

        public MyFileSystem FileSystem { get; } = new MyFileSystem();
        public MyNetwork Network { get; } = new MyNetwork();
        public MyKeyboard Keyboard { get; } = new MyKeyboard();
        public MyMouse Mouse { get; } = new MyMouse();
        public MyClipboard Clipboard { get; } = new MyClipboard();

        public string Name => Environment.MachineName;

        public MyScreen Screen { get; } = new MyScreen();
        public MyRegistry Registry { get; } = new MyRegistry();
    }

    public class MyFileSystem
    {
        public string CurrentDirectory
        {
            get => Directory.GetCurrentDirectory();
            set => Directory.SetCurrentDirectory(value);
        }

        public string[] GetFiles(string directory)
        => Directory.GetFiles(directory);

        public string[] GetFiles(string directory, string searchPattern)
            => Directory.GetFiles(directory, searchPattern);

        public string[] GetFiles(string directory, string searchPattern, SearchOption searchOption)
            => Directory.GetFiles(directory, searchPattern, searchOption);

        public string[] GetDirectories(string directory)
            => Directory.GetDirectories(directory);

        public string[] GetDirectories(string directory, string searchPattern)
            => Directory.GetDirectories(directory, searchPattern);

        public string[] GetDirectories(string directory, string searchPattern, SearchOption searchOption)
            => Directory.GetDirectories(directory, searchPattern, searchOption);

        public bool FileExists(string file) => File.Exists(file);
        public bool DirectoryExists(string directory) => Directory.Exists(directory);

        public void CreateDirectory(string directory) => Directory.CreateDirectory(directory);

        public void DeleteFile(string file) => File.Delete(file);
        public void DeleteDirectory(string directory, bool recursive) =>
            Directory.Delete(directory, recursive);

        public void CopyFile(string sourceFile, string destinationFile, bool overwrite = false) =>
            File.Copy(sourceFile, destinationFile, overwrite);

        public void MoveFile(string sourceFile, string destinationFile) =>
            File.Move(sourceFile, destinationFile);

        public void MoveDirectory(string sourceDirectory, string destinationDirectory) =>
            Directory.Move(sourceDirectory, destinationDirectory);

        public string ReadAllText(string file) => File.ReadAllText(file);
        public string ReadAllText(string file, System.Text.Encoding encoding) =>
            File.ReadAllText(file, encoding);

        public void WriteAllText(string file, string text, bool append)
        {
            if (append)
                File.AppendAllText(file, text);
            else
                File.WriteAllText(file, text);
        }

        public byte[] ReadAllBytes(string file) => File.ReadAllBytes(file);
        public void WriteAllBytes(string file, byte[] data) => File.WriteAllBytes(file, data);

        public string GetTempFileName() => Path.GetTempFileName();
        public string SpecialDirectories_Temp => Path.GetTempPath();

        // MoveFile с 3 аргументами (overwrite)
        public void MoveFile(string sourceFile, string destinationFile, bool overwrite)
        {
            if (overwrite && File.Exists(destinationFile))
                File.Delete(destinationFile);
            File.Move(sourceFile, destinationFile);
        }

        // WriteAllText с 4 аргументами (file, text, append, encoding)
        public void WriteAllText(string file, string text, bool append, System.Text.Encoding encoding)
        {
            if (append)
                File.AppendAllText(file, text, encoding);
            else
                File.WriteAllText(file, text, encoding);
        }

    }

    public class MyNetwork
    {
        public bool IsAvailable =>
            System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable();
    }

    public class MyKeyboard
    {
        public bool CapsLock => Control.IsKeyLocked(Keys.CapsLock);
        public bool NumLock => Control.IsKeyLocked(Keys.NumLock);
        public bool ScrollLock => Control.IsKeyLocked(Keys.Scroll);
    }

    public class MyMouse
    {
        public bool ButtonsSwapped => SystemInformation.MouseButtonsSwapped;
        public bool WheelExists => SystemInformation.MouseWheelPresent;
        public int WheelScrollLines => SystemInformation.MouseWheelScrollLines;
    }

    public class MyClipboard
    {
        public bool ContainsText() => Clipboard.ContainsText();
        public string GetText() => Clipboard.GetText();
        public void SetText(string text) => Clipboard.SetText(text);
    }

    public class MyUser
    {
        public System.Security.Principal.IPrincipal CurrentPrincipal
        {
            get => Thread.CurrentPrincipal;
            set => Thread.CurrentPrincipal = value;
        }

        public System.Security.Principal.IIdentity CurrentUser => Thread.CurrentPrincipal?.Identity;
        public string Name => Thread.CurrentPrincipal?.Identity?.Name ?? string.Empty;

        public bool IsInRole(string role) =>
            Thread.CurrentPrincipal?.IsInRole(role) ?? false;

        public bool IsAuthenticated =>
            Thread.CurrentPrincipal?.Identity?.IsAuthenticated ?? false;
    }

    [HideModuleName()]
    [System.CodeDom.Compiler.GeneratedCode("MyTemplate", "11.0.0.0")]
    internal static partial class MyProject
    {
        [System.ComponentModel.Design.HelpKeyword("My.Computer")]
        internal static MyComputer Computer
        {
            [DebuggerHidden()]
            get => m_ComputerObjectProvider.GetInstance;
        }
        private readonly static ThreadSafeObjectProvider<MyComputer> m_ComputerObjectProvider =
            new ThreadSafeObjectProvider<MyComputer>();

        [System.ComponentModel.Design.HelpKeyword("My.Application")]
        internal static MyApplication Application
        {
            [DebuggerHidden()]
            get => m_AppObjectProvider.GetInstance;
        }
        private readonly static ThreadSafeObjectProvider<MyApplication> m_AppObjectProvider =
            new ThreadSafeObjectProvider<MyApplication>();

        [System.ComponentModel.Design.HelpKeyword("My.User")]
        internal static Microsoft.VisualBasic.ApplicationServices.User User
        {
            [DebuggerHidden()]
            get => m_UserObjectProvider.GetInstance;
        }

        private readonly static ThreadSafeObjectProvider<Microsoft.VisualBasic.ApplicationServices.User> m_UserObjectProvider =
            new ThreadSafeObjectProvider<Microsoft.VisualBasic.ApplicationServices.User>();

        [System.ComponentModel.Design.HelpKeyword("My.Forms")]
        internal static MyForms Forms
        {
            [DebuggerHidden()]
            get => m_MyFormsObjectProvider.GetInstance;
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        [MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
        internal sealed partial class MyForms
        {
            [DebuggerHidden()]
            private static T Create__Instance__<T>(T Instance) where T : Form, new()
            {
                if (Instance is null || Instance.IsDisposed)
                {
                    if (m_FormBeingCreated is object)
                    {
                        if (m_FormBeingCreated.ContainsKey(typeof(T)) == true)
                        {
                            throw new InvalidOperationException(
                                "An attempt was made to create a form recursively.");
                        }
                    }
                    else
                    {
                        m_FormBeingCreated = new Hashtable();
                    }

                    m_FormBeingCreated.Add(typeof(T), null);
                    try
                    {
                        return new T();
                    }
                    catch (System.Reflection.TargetInvocationException ex) when (ex.InnerException is object)
                    {
                        throw new InvalidOperationException(
                            $"An error occurred creating the form. See InnerException: {ex.InnerException.Message}",
                            ex.InnerException);
                    }
                    finally
                    {
                        m_FormBeingCreated.Remove(typeof(T));
                    }
                }
                else
                {
                    return Instance;
                }
            }

            [DebuggerHidden()]
            private void Dispose__Instance__<T>(ref T instance) where T : Form
            {
                instance.Dispose();
                instance = null;
            }

            [DebuggerHidden()]
            [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
            public MyForms() : base()
            {
            }

            [ThreadStatic()]
            private static Hashtable m_FormBeingCreated;

            [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
            public override bool Equals(object o) => base.Equals(o);

            [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
            public override int GetHashCode() => base.GetHashCode();

            [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
            internal new Type GetType() => typeof(MyForms);

            [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
            public override string ToString() => base.ToString();
        }

        private static ThreadSafeObjectProvider<MyForms> m_MyFormsObjectProvider =
            new ThreadSafeObjectProvider<MyForms>();

        [System.ComponentModel.Design.HelpKeyword("My.WebServices")]
        internal static MyWebServices WebServices
        {
            [DebuggerHidden()]
            get => m_MyWebServicesObjectProvider.GetInstance;
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        [MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
        internal sealed class MyWebServices
        {
            [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
            [DebuggerHidden()]
            public override bool Equals(object o) => base.Equals(o);

            [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
            [DebuggerHidden()]
            public override int GetHashCode() => base.GetHashCode();

            [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
            [DebuggerHidden()]
            internal new Type GetType() => typeof(MyWebServices);

            [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
            [DebuggerHidden()]
            public override string ToString() => base.ToString();

            [DebuggerHidden()]
            private static T Create__Instance__<T>(T instance) where T : new() =>
                instance is null ? new T() : instance;

            [DebuggerHidden()]
            private void Dispose__Instance__<T>(ref T instance) => instance = default;

            [DebuggerHidden()]
            [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
            public MyWebServices() : base()
            {
            }
        }

        private readonly static ThreadSafeObjectProvider<MyWebServices> m_MyWebServicesObjectProvider =
            new ThreadSafeObjectProvider<MyWebServices>();

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        [ComVisible(false)]
        internal sealed class ThreadSafeObjectProvider<T> where T : new()
        {
            internal T GetInstance
            {
                [DebuggerHidden()]
                get
                {
                    if (m_ThreadStaticValue is null)
                        m_ThreadStaticValue = new T();
                    return m_ThreadStaticValue;
                }
            }

            [DebuggerHidden()]
            [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
            public ThreadSafeObjectProvider() : base()
            {
            }

            [System.Runtime.CompilerServices.CompilerGenerated()]
            [ThreadStatic()]
            private static T m_ThreadStaticValue;
        }
    }

    /// <summary>
    /// Stub attribute replacing Microsoft.VisualBasic.HideModuleNameAttribute
    /// </summary>
    [AttributeUsage(AttributeTargets.Class)]
    internal sealed class HideModuleNameAttribute : Attribute { }

    /// <summary>
    /// Stub attribute replacing Microsoft.VisualBasic.MyGroupCollectionAttribute
    /// </summary>
    [AttributeUsage(AttributeTargets.Class)]
    internal sealed class MyGroupCollectionAttribute : Attribute
    {
        public string TypeToCollect { get; }
        public string CreateInstanceMethodName { get; }
        public string DisposeInstanceMethodName { get; }
        public string DefaultInstanceAlias { get; }

        public MyGroupCollectionAttribute(
            string typeToCollect,
            string createInstanceMethodName,
            string disposeInstanceMethodName,
            string defaultInstanceAlias)
        {
            TypeToCollect = typeToCollect;
            CreateInstanceMethodName = createInstanceMethodName;
            DisposeInstanceMethodName = disposeInstanceMethodName;
            DefaultInstanceAlias = defaultInstanceAlias;
        }
    }
}