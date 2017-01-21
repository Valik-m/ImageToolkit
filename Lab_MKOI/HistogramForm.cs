using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Lab_MKOI
{
    public partial class HistogramForm : Form
    {
        Bitmap img;
        int[] brightDistrib;
        MainForm mainForm;
        public HistogramForm(int[] brightDistrib, Bitmap img, MainForm mainForm)
        {
            InitializeComponent();
            this.img = img;
            this.mainForm = mainForm;
            this.brightDistrib = brightDistrib;
            for (int i = 0; i < brightDistrib.Length; i++)
            {
                this.brightChart.Series[0].Points.Add(brightDistrib[i]);
            }   
                   
        }

        private void equalizationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BitmapRawData bitmapRD = BitmapImageConverter.ConvertToRawDataFromImage(img);
            equalization(bitmapRD);
            int[] newBrightDistrib = new int[256];
            for (int i = 0; i < bitmapRD.RgbArray.Length; i++)
            {
                newBrightDistrib[bitmapRD.RgbArray[i]]++;
            }
            Series series = new Series();
            series.Name = "После эквилизации";
            brightChart.Series.Add(series);
            for (int i = 0; i < newBrightDistrib.Length; i++)
            {
                brightChart.Series[1].Points.Add(newBrightDistrib[i]);
            }
            mainForm.afterPictureBox.Image = BitmapImageConverter.ConvertToImageFromRawData(bitmapRD);
        }
        private void equalization(BitmapRawData bitmapRD)
        {
            
            byte[] N = new byte[256];
            byte[] left = new byte[256];
            byte[] right = new byte[256];
            int z = 0;
            int Hint = 0;
            var rgbArray = bitmapRD.RgbArray;
            int Havg = rgbArray.Length / brightDistrib.Length;
            for (int i = 0; i < N.Length - 1; i++)
            {
                N[i] = 0;
            }
            for (int j = 0; j < brightDistrib.Length; j++)
            {
                if (z > 255) left[j] = 255;
                else left[j] = (byte)z;
                Hint += brightDistrib[j];
                while (Hint > Havg)
                {
                    Hint -= Havg;
                    z++;
                }
                if (z > 255) right[j] = 255;
                else right[j] = (byte)z;

                N[j] = (byte)((left[j] + right[j]) / 2);
            }
            for (int i = 0; i < rgbArray.Length; i++)
            {
                if (left[rgbArray[i]] == right[rgbArray[i]]) rgbArray[i] = left[rgbArray[i]];
                else rgbArray[i] = N[rgbArray[i]];
            }
        }
    }
}
