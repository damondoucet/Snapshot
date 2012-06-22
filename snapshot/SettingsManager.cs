using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace Snapshot
{
    public class SettingsManager : IDisposable
    {
        public string Hotkey { get; set; }
        public string SaveDirectory { get; set; }

        public SettingsManager()
        {
            Hotkey = Properties.Settings.Default.Hotkey;
            SaveDirectory = Properties.Settings.Default.SaveDirectory;
        }

        public void Dispose()
        {
            Properties.Settings.Default.Hotkey = Hotkey;
            Properties.Settings.Default.SaveDirectory = SaveDirectory;
            Properties.Settings.Default.Save();
        }
    }
}
