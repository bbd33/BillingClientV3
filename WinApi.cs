using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Diagnostics;

namespace BillingClientV3
{
    /// <summary>
    /// Win32 implementation to show / hide a window with animation.
    /// </summary>

    public class WinAPI
    {
        /// <summary>
        /// Animates the window from left to right. This flag can be used with roll or slide animation.
        /// </summary>
        public const int AW_HOR_POSITIVE = 0X1;
        /// <summary>
        /// Animates the window from right to left. This flag can be used with roll or slide animation.
        /// </summary>
        public const int AW_HOR_NEGATIVE = 0X2;
        /// <summary>
        /// Animates the window from top to bottom. This flag can be used with roll or slide animation.
        /// </summary>
        public const int AW_VER_POSITIVE = 0X4;
        /// <summary>
        /// Animates the window from bottom to top. This flag can be used with roll or slide animation.
        /// </summary>
        public const int AW_VER_NEGATIVE = 0X8;
        /// <summary>
        /// Makes the window appear to collapse inward if AW_HIDE is used or expand outward if the AW_HIDE is not used.
        /// </summary>
        public const int AW_CENTER = 0X10;
        /// <summary>
        /// Hides the window. By default, the window is shown.
        /// </summary>
        public const int AW_HIDE = 0X10000;
        /// <summary>
        /// Activates the window.
        /// </summary>
        public const int AW_ACTIVATE = 0X20000;
        /// <summary>
        /// Uses slide animation. By default, roll animation is used.
        /// </summary>
        public const int AW_SLIDE = 0X40000;
        /// <summary>
        /// Uses a fade effect. This flag can be used only if hwnd is a top-level window.
        /// </summary>
        public const int AW_BLEND = 0X80000;

        /// <summary>
        /// Animates a window.
        /// </summary>
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int AnimateWindow(IntPtr hwand, int dwTime, int dwFlags);

        [DllImport("jangkrik.dll")]
        static extern int TaskSwitching_Enable_Disable(bool bEnableDisable);

        public static class Taskbar
        {
            [DllImport("user32.dll")]
            private static extern int GetWindowText(IntPtr hWnd, StringBuilder text, int count);
            [DllImport("user32.dll", CharSet = CharSet.Auto)]
            private static extern bool EnumThreadWindows(int threadId, EnumThreadProc pfnEnum, IntPtr lParam);
            [DllImport("user32.dll", SetLastError = true)]
            private static extern System.IntPtr FindWindow(string lpClassName, string lpWindowName);
            [DllImport("user32.dll", SetLastError = true)]
            private static extern IntPtr FindWindowEx(IntPtr parentHandle, IntPtr childAfter, string className, string windowTitle);
            [DllImport("user32.dll")]
            private static extern IntPtr FindWindowEx(IntPtr parentHwnd, IntPtr childAfterHwnd, IntPtr className, string windowText);
            [DllImport("user32.dll")]
            private static extern int ShowWindow(IntPtr hwnd, int nCmdShow);
            [DllImport("user32.dll")]
            private static extern uint GetWindowThreadProcessId(IntPtr hwnd, out int lpdwProcessId);

            private const int SW_HIDE = 0;
            private const int SW_SHOW = 5;

            private const string VistaStartMenuCaption = "Start";
            private static IntPtr vistaStartMenuWnd = IntPtr.Zero;
            private delegate bool EnumThreadProc(IntPtr hwnd, IntPtr lParam);

            /// <summary>
            /// Show the taskbar.
            /// </summary>
            public static void Show()
            {
                SetVisibility(true);
            }

            /// <summary>
            /// Hide the taskbar.
            /// </summary>
            public static void Hide()
            {
                SetVisibility(false);
            }

            /// <summary>
            /// Sets the visibility of the taskbar.
            /// </summary>
            public static bool Visible
            {
                set { SetVisibility(value); }
            }

            /// <summary>
            /// Hide or show the Windows taskbar and startmenu.
            /// </summary>
            /// <param name="show">true to show, false to hide</param>
            private static void SetVisibility(bool show)
            {
                // get taskbar window
                IntPtr taskBarWnd = FindWindow("Shell_TrayWnd", null);

                // try it the WinXP way first...
                IntPtr startWnd = FindWindowEx(taskBarWnd, IntPtr.Zero, "Button", "Start");

                if (startWnd == IntPtr.Zero)
                {
                    // try an alternate way, as mentioned on CodeProject by Earl Waylon Flinn
                    startWnd = FindWindowEx(IntPtr.Zero, IntPtr.Zero, (IntPtr)0xC017, "Start");
                }

                if (startWnd == IntPtr.Zero)
                {
                    // ok, let's try the Vista easy way...
                    startWnd = FindWindow("Button", null);

                    if (startWnd == IntPtr.Zero)
                    {
                        // no chance, we need to to it the hard way...
                        startWnd = GetVistaStartMenuWnd(taskBarWnd);
                    }
                }

                ShowWindow(taskBarWnd, show ? SW_SHOW : SW_HIDE);
                ShowWindow(startWnd, show ? SW_SHOW : SW_HIDE);
            }

            /// <summary>
            /// Returns the window handle of the Vista start menu orb.
            /// </summary>
            /// <param name="taskBarWnd">windo handle of taskbar</param>
            /// <returns>window handle of start menu</returns>
            private static IntPtr GetVistaStartMenuWnd(IntPtr taskBarWnd)
            {
                // get process that owns the taskbar window
                int procId;
                GetWindowThreadProcessId(taskBarWnd, out procId);

                Process p = Process.GetProcessById(procId);
                if (p != null)
                {
                    // enumerate all threads of that process...
                    foreach (ProcessThread t in p.Threads)
                    {
                        EnumThreadWindows(t.Id, MyEnumThreadWindowsProc, IntPtr.Zero);
                    }
                }
                return vistaStartMenuWnd;
            }

            /// <summary>
            /// Callback method that is called from 'EnumThreadWindows' in 'GetVistaStartMenuWnd'.
            /// </summary>
            /// <param name="hWnd">window handle</param>
            /// <param name="lParam">parameter</param>
            /// <returns>true to continue enumeration, false to stop it</returns>
            private static bool MyEnumThreadWindowsProc(IntPtr hWnd, IntPtr lParam)
            {
                StringBuilder buffer = new StringBuilder(256);
                if (GetWindowText(hWnd, buffer, buffer.Capacity) > 0)
                {
                    Console.WriteLine(buffer);
                    if (buffer.ToString() == VistaStartMenuCaption)
                    {
                        vistaStartMenuWnd = hWnd;
                        return false;
                    }
                }
                return true;
            }
        }
    }
}
