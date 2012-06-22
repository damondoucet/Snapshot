using System;
using System.IO;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using System.Diagnostics;
using System.Linq;

using Snapshot.KeyboardHook;

namespace Snapshot
{
    public partial class Main : Form
    {
        private int _currentIndex;
        private List<string> _picturePaths;

        private Hook _hook;
        private PictureTaker _pictureTaker;
        private SettingsManager _settingsManager;

        #region Initialization

        public Main()
        {
            _currentIndex = -1;
            _picturePaths = new List<string>();

            _settingsManager = new SettingsManager();
            InitializePictureTaker();
            InitializeHook();

            InitializeComponent();

            SetImageControlsEnabled(false);
        }

        private void InitializePictureTaker()
        {
            _pictureTaker = new PictureTaker(Environment.CurrentDirectory);
            _pictureTaker.OnPictureTaken += OnPictureTaken;
        }

        private void InitializeHook()
        {
            _hook = new Hook();
            _hook.RegisterHotkey(_settingsManager.Hotkey, _pictureTaker.TakePicture);
        }

        private void OnFormClosing(object sender, FormClosingEventArgs e)
        {
            _hook.Dispose();
            _settingsManager.Dispose();
        }

        #endregion 

        private void OnPictureTaken(string path)
        {
            _picturePaths.Add(path);

            if (_picturePaths.Count == 1)
            {
                _currentIndex = 0;
                SetImageControlsEnabled(true);
                LoadImage();
            }
            else
                UpdatePreviousNextEnabled();
        }

        private void OnPictureBoxDoubleClick(object sender, EventArgs e)
        {
            new Process() 
            { 
                StartInfo = new ProcessStartInfo(_picturePaths[_currentIndex]) 
                    { UseShellExecute = true } 
            }.Start();
        }

        private void SetImageControlsEnabled(bool enabled)
        {
           _save.Enabled =
                _delete.Enabled =
                _pictureBox.Visible = enabled;
           _noPicturesLabel.Visible = !enabled;

           if (enabled)
               UpdatePreviousNextEnabled();
           else
           {
               _next.Enabled = _previous.Enabled = false;
               _pictureBox.Image = null;
           }
        }

        #region Removing Pictures From List

        private void RemoveCurrentIndex(Action<int> remover)
        {
            remover(_currentIndex);
            _picturePaths.RemoveAt(_currentIndex);

            UpdateIndexAfterPictureRemoved();
        }

        private void UpdateIndexAfterPictureRemoved()
        {
            if (_currentIndex == _picturePaths.Count)
                _currentIndex--;
            UpdatePreviousNextEnabled();

            if (_picturePaths.Count == 0)
                SetImageControlsEnabled(false);
            else
                LoadImage();
        }

        private void OnSaveClick(object sender, EventArgs e)
        {
            RemoveCurrentIndex(index => File.Move(_picturePaths[index], FindNewPath()));
        }

        private void OnDeleteClick(object sender, EventArgs e)
        {
            RemoveCurrentIndex(index => File.Delete(_picturePaths[index]));
        }

        private string FindNewPath()
        {
            var dir = _settingsManager.SaveDirectory;
            int value = GetLargestIntegerFromFiles(Directory.GetFiles(dir)) + 1; 

            return Path.Combine(dir, value + ".jpg");
        }

        private int GetLargestIntegerFromFiles(string[] files)
        {
            return files.Max((Func<string, int>)GetIntegerFromFile);
        }

        private int GetIntegerFromFile(string file)
        { 
            int val;
            return int.TryParse(Path.GetFileNameWithoutExtension(file), out val) ? val : 0;
        }

        #endregion

        #region Picture Cycling

        private void UpdatePreviousNextEnabled()
        {
            _next.Enabled = _currentIndex < _picturePaths.Count - 1;
            _previous.Enabled = _currentIndex > 0;
        }

        private void OnPreviousClick(object sender, EventArgs e)
        {
            _currentIndex--;

            UpdatePreviousNextEnabled();

            LoadImage();
        }

        private void OnNextClick(object sender, EventArgs e)
        {
            _currentIndex++;

            UpdatePreviousNextEnabled();

            LoadImage();
        }

        private void LoadImage()
        {
            //Image.FromFile() will lock the file which means we can't delete it so we read from a stream instead
            using (var fs = new FileStream(_picturePaths[_currentIndex], FileMode.Open, FileAccess.Read))
            {
                var image = Image.FromStream(fs);
                var bitmap = new Bitmap(_pictureBox.Width, _pictureBox.Height);

                using (var graphics = Graphics.FromImage(bitmap))
                    graphics.DrawImage(image, 0, 0, _pictureBox.Width, _pictureBox.Height);

                _pictureBox.Image = bitmap;
            }
        }

        #endregion

        #region Tray

        private void OnResize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
                this.Hide();
        }

        private void OnNotifyIconDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        #endregion
    }
}
