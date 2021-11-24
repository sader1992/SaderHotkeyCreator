using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Windows.Input;
//Thenks to: https://docs.microsoft.com/en-us/archive/blogs/toub/low-level-keyboard-hook-in-c

namespace Sader_Hotkey_Creator
{
    static class Program
    {
        private const int WH_KEYBOARD_LL = 13;
        private const int WM_KEYDOWN = 0x0100;
        private const int WM_SYSKEYDOWN = 0x0104;
        private static LowLevelKeyboardProc _proc = HookCallback;
        private static IntPtr _hookID = IntPtr.Zero;

        [STAThread]
        static void Main()
        {
            if (Process.GetProcessesByName(V.application_name).Length > 1)
            {
                MessageBox.Show("There is another insteance of the same program running , close it first!");
                Form1.fully_exit = true;
                Application.Exit();
                return;
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            _hookID = SetHook(_proc);
            Application.Run(new Form1());
            UnhookWindowsHookEx(_hookID);
        }

        private static IntPtr SetHook(LowLevelKeyboardProc proc)
        {
            using (Process curProcess = Process.GetCurrentProcess())
            using (ProcessModule curModule = curProcess.MainModule)
            {
                return SetWindowsHookEx(WH_KEYBOARD_LL, proc,
                    GetModuleHandle(curModule.ModuleName), 0);
            }
        }

        private delegate IntPtr LowLevelKeyboardProc(
            int nCode, IntPtr wParam, IntPtr lParam);

        private static IntPtr HookCallback(
            int nCode, IntPtr wParam, IntPtr lParam)
        {
            if (nCode >= 0 && wParam == (IntPtr)WM_KEYDOWN)
            {
                int vkCode = Marshal.ReadInt32(lParam);
                for (int i = 0; i < V.Key_1.Count; i++)
                {
                    if(Keyboard.IsKeyDown(V.Key_1[i]) && V.Key_2[i] == (Keys)vkCode)
                    {
                        switch (V.Type[i])
                        {
                            case V.CommandList.PowerShell:
                                Process.Start("powershell.exe", V.Commands[i]);
                                break;
                            case V.CommandList.CMD:
                                Process.Start("cmd.exe", "/C " + V.Commands[i]);
                                break;
                            case V.CommandList.CMDAdmin:
                                Process CMDAdmin = new Process();
                                CMDAdmin.StartInfo.FileName = "cmd.exe";
                                CMDAdmin.StartInfo.Arguments = "/C " + V.Commands[i];
                                CMDAdmin.EnableRaisingEvents = true;
                                CMDAdmin.StartInfo.UseShellExecute = true;
                                CMDAdmin.StartInfo.Verb = "runas";
                                CMDAdmin.Start();
                                break;
                            case V.CommandList.OpenAppAdmin:
                                try
                                {

                                    Process OpenAppAdmin = new Process();
                                    OpenAppAdmin.StartInfo.FileName = V.Commands[i];
                                    OpenAppAdmin.EnableRaisingEvents = true;
                                    OpenAppAdmin.StartInfo.UseShellExecute = true;
                                    OpenAppAdmin.StartInfo.Verb = "runas";
                                    OpenAppAdmin.Start();

                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("An error occurred!!!: " + ex.Message);
                                }
                                break;
                            case V.CommandList.OpenApp:
                                try
                                {
                                    Process OpenApp = new Process();
                                    OpenApp.StartInfo.FileName = V.Commands[i];
                                    OpenApp.EnableRaisingEvents = true;
                                    OpenApp.StartInfo.UseShellExecute = true;
                                    OpenApp.Start();
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("An error occurred!!!: " + ex.Message);
                                }
                                break;
                            case V.CommandList.OpenFile:
                                try
                                {

                                    Process OpenFile = new Process();
                                    OpenFile.StartInfo.FileName = V.Commands[i];
                                    OpenFile.EnableRaisingEvents = true;
                                    OpenFile.StartInfo.Verb = "Open";
                                    OpenFile.Start();

                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("An error occurred!!!: " + ex.Message);
                                }
                                break;
                        }
                    }
                }
            }
            return CallNextHookEx(_hookID, nCode, wParam, lParam);
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr SetWindowsHookEx(int idHook,
            LowLevelKeyboardProc lpfn, IntPtr hMod, uint dwThreadId);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool UnhookWindowsHookEx(IntPtr hhk);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode,
            IntPtr wParam, IntPtr lParam);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr GetModuleHandle(string lpModuleName);

    }
}
