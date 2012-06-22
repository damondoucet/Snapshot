using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace Snapshot.KeyboardHook
{
    internal static class HookApi
    {
        public delegate IntPtr HookDelegate(int nCode, IntPtr wParam, IntPtr lParam);
        
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr SetWindowsHookEx(
            int idHook,
            HookDelegate lpfn,
            IntPtr hMod,
            uint dwThreadId);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool UnhookWindowsHookEx(
            IntPtr hhk);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr CallNextHookEx(
            IntPtr hhk,
            int nCode,
            IntPtr
            wParam,
            IntPtr lParam);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr GetModuleHandle(
            string lpModuleName);
    }
}
