using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.IO;

namespace Snapshot
{
    class PictureTaker
    {
        private string _saveDirectory;
        public event Action<string> OnPictureTaken;

        public PictureTaker(string saveDirectory)
        {
            _saveDirectory = saveDirectory;
        }

        public void TakePicture()
        {
            Screen.AllScreens.ToList().ForEach(TakePictureOfScreen);            
        }

        private void TakePictureOfScreen(Screen screen)
        {
            using (var bitmap = new Bitmap(screen.Bounds.Width, screen.Bounds.Height))
            {
                using (var graphics = Graphics.FromImage(bitmap))
                {
                    graphics.CopyFromScreen(0, 0, 0, 0, bitmap.Size);

                    string path = Path.Combine(_saveDirectory, DateTime.Now.Ticks + ".png");
                    bitmap.Save(path, ImageFormat.Png);

                    FirePictureTakenEvent(path);
                }
            }
        }

        private void FirePictureTakenEvent(string path)
        {
            if (OnPictureTaken != null)
                OnPictureTaken(path);
        }
    }
}
