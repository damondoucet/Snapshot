using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace Snapshot.KeyboardHook
{
    public class Hook : IDisposable
    {
        private const int WH_KEYBOARD_LL = 13;

        private IntPtr _hookHandle;
        private Dictionary<VirtualKey, Action> _hotkeys;
        private HookApi.HookDelegate _delegate;

        public Hook()
        {
            _hotkeys = new Dictionary<VirtualKey, Action>();
            _delegate = HookDelegate;
            CreateHook();
        }

        ~Hook()
        {
            Dispose();
        }

        public void Dispose()
        {
            DestroyHook();
        }

        private void DestroyHook()
        {
            HookApi.UnhookWindowsHookEx(_hookHandle);
        }

        private void CreateHook()
        {
            _hookHandle = HookApi.SetWindowsHookEx(
                WH_KEYBOARD_LL, 
                _delegate, 
                HookApi.GetModuleHandle(Process.GetCurrentProcess().MainModule.ModuleName),
                0);
        }

        private IntPtr HookDelegate(int nCode, IntPtr wParam, IntPtr lParam)
        {
            var message = new Message() { nCode = nCode, wParam = wParam, lParam = lParam };

            if (message.ShouldBeProcessed())
                ProcessMessage(message);

            return HookApi.CallNextHookEx(_hookHandle, nCode, wParam, lParam);
        }

        private void ProcessMessage(Message message)
        {
            if (_hotkeys.ContainsKey(message.Key))
                _hotkeys[message.Key]();
        }

        public void RegisterHotkey(VirtualKey key, Action action)
        {
            _hotkeys[key] = action;
        }

        public void RegisterHotkey(string key, Action action)
        {
            RegisterHotkey((VirtualKey)Enum.Parse(typeof(VirtualKey), key), action);
        }

        public void UnregisterHotkey(VirtualKey key)
        {
            _hotkeys.Remove(key);
        }
    }
}
