using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace AppleWirelessKeyboard
{
    public static class VolumeControl
    {
        [DllImport("user32.dll")]
        static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, int dwExtraInfo);

        public static void ToggleMute()
        {
            keybd_event((byte)Keys.VolumeMute, 0, 0, 0);
        }
        public static void VolumeUp()
        {
            keybd_event((byte)Keys.VolumeUp, 0, 0, 0);
        }
        public static void VolumeDown()
        {
            keybd_event((byte)Keys.VolumeDown, 0, 0, 0);
        }
    }
}
