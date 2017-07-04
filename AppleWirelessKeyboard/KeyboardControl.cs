using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Windows.Input;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppleWirelessKeyboard
{
    public static class KeyboardControl
    {
        const int VK_SNAPSHOT = 44;
        const int VK_DELETE = 46;
        const int VK_MEDIA_NEXT_TRACK = 176;
        const int VK_MEDIA_PREV_TRACK = 177;
        const int VK_MEDIA_STOP = 178;
        const int VK_MEDIA_PLAY_PAUSE = 179;
        const int VK_END = 0x23;
        const int VK_HOME = 0x24;
        const int VK_PAGEUP = 0x21;
        const int VK_PAGEDOWN = 0x22;
        const int VK_F3 = 117;
        const int VK_INSERT = 45;

        public static void Send(int VKey, KeyboardEvent e = KeyboardEvent.Both)
        {
            switch (e)
            {
                case KeyboardEvent.Both:
                    {
                        keybd_event((byte)VKey, 0, 0, 0);
                        keybd_event((byte)VKey, 0, 2, 0);
                    }
                    break;
                case KeyboardEvent.Down:
                    keybd_event((byte)VKey, 0, 0, 0);
                    break;
                case KeyboardEvent.Up:
                    keybd_event((byte)VKey, 0, 2, 0);
                    break;
            }
        }

        public static void SendInsert()
        {
            Task.Factory.StartNew(() =>
            {
                Send(VK_INSERT);
            });
        }

        public static void SendDelete()
        {
            Task.Factory.StartNew(() =>
            {
                Send(VK_DELETE);
            });
        }

        public static void SendPrintScreen()
        {
            Task.Factory.StartNew(() =>
            {
                Send(VK_SNAPSHOT);
                Thread.Sleep(100);
                NotificationCenter.NotifyPrintScreen();
            });
        }

        public static void SendPlayPause()
        {
            keybd_event((byte)Keys.MediaPlayPause, 0, 0, 0);
        }

        public static void SendNextTrack() {
            keybd_event((byte)Keys.MediaNextTrack, 0, 0, 0);
        }

        public static void SendPreviousTrack() {
            keybd_event((byte)Keys.MediaPreviousTrack, 0, 0, 0);
        }

        public static void OpenTaskManager()
        {
            Task.Factory.StartNew(() =>
            {
                Process taskmgr = Process.GetProcessesByName("taskmgr.exe").FirstOrDefault();
                if (taskmgr != null)
                    SetForegroundWindow(taskmgr.MainWindowHandle);
                else
                    Process.Start("taskmgr.exe");
                NotificationCenter.NotifyTaskManager();
            });
        }

        #region PInvoke
        [DllImport("user32.dll")]
        static extern bool SetForegroundWindow(IntPtr hWnd);

        [DllImport("user32.dll")]
        static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, int dwExtraInfo);

        public enum KeyboardEvent
        {
            Down = 0, Up = 2, Both
        }
        #endregion

        public static void SendPageUp()
        {
            Task.Factory.StartNew(() =>
            {
                Send(VK_PAGEUP);
            });
        }
        public static void SendPageDown()
        {
            Task.Factory.StartNew(() =>
            {
                Send(VK_PAGEDOWN);
            });
        }
        public static void SendHome()
        {
            Task.Factory.StartNew(() =>
            {
                Send(VK_HOME);
            });
        }
        public static void SendEnd()
        {
            Task.Factory.StartNew(() =>
            {
                Send(VK_END);
            });
        }

        public static void SendF3()
        {
            Task.Factory.StartNew(() =>
            {
                Send(VK_F3);
            });
        }
    }
}
