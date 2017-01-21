using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_MKOI
{
    public partial class BitPlainForm : Form
    {
        Bitmap img;
        public BitPlainForm(Bitmap img)
        {
            InitializeComponent();
            this.img = img;
            BitPlain(img);
        }
        
        private void BitPlain(Bitmap img)
        {
            
            byte[] maskArray = new byte[8] { 0x01, 0x02, 0x04, 0x08, 0x10, 0x20, 0x40, 0x80 };
            Bitmap[] bitPlainArray = new Bitmap[8];
            BitmapRawData bitmapRD = BitmapImageConverter.ConvertToRawDataFromImage(img);
            bitmapRD.RgbArray = CalculateRelativeBrightness.Calculate(bitmapRD.RgbArray);
            for (int i = 0; i < 8; i++)
            {
                var rgbArray = new int[bitmapRD.RgbArray.Length];
                Array.Copy(bitmapRD.RgbArray, rgbArray, bitmapRD.RgbArray.Length);
                for (int j = 0; j < rgbArray.Length; j++)
                {
                    rgbArray[j] &= (byte)maskArray[i];
                    rgbArray[j] = rgbArray[j] != 0 ? 255 : 0;
                }
                var newBitmapRD = new BitmapRawData(rgbArray, bitmapRD.AlphaArray, bitmapRD.Width, bitmapRD.Height);
                bitPlainArray[i] = BitmapImageConverter.ConvertToImageFromRawData(newBitmapRD);
            }
            int k = 0;
            foreach (var control in Controls)
            {
                PictureBox pictureBox = control as PictureBox;
                if (pictureBox != null)
                    pictureBox.Image = bitPlainArray[k++];
            }
        }
    }
}
