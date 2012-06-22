using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace Snapshot.KeyboardHook
{
    class Message
    {
        private const int HC_ACTION = 0;
        private const int WM_KEYDOWN = 0x100;
        private const int WM_SYSKEYDOWN = 0x104;
        
        public int nCode { get; set; }
        public IntPtr wParam { get; set; }

        private IntPtr _lParam;
        public IntPtr lParam 
        {
            get { return _lParam; }
            set 
            {
                _lParam = value;
                Key = (VirtualKey)Marshal.ReadInt32(value);
            }
        }

        public VirtualKey Key { get; private set; }

        public bool ShouldBeProcessed()
        {
            return nCode == HC_ACTION && IsKeyDown();
        }

        private bool IsKeyDown()
        {
            int key = wParam.ToInt32();
            return key == WM_KEYDOWN || key == WM_SYSKEYDOWN;
        }
    }
}
