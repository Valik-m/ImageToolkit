using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using System.Collections;
using System.Collections.Generic;

namespace Lab_MKOI
{
    public partial class MainForm : Form
    {
        PromptForm promptForm;

        private enum RGB
        {
            R,
            G,
            B
        }

        public MainForm()
        {
            InitializeComponent();
        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(openFileDialog.FileName, FileMode.Open);
                Image img = Image.FromStream(fs);
                fs.Close();
                beforePictureBox.Image = img;                
            }
        }

        private bool isImageLoad()
        {
            if (beforePictureBox.Image != null)
                return true;
            else return false;
        }

        private byte Max(byte a, byte b)
        {
            if (a > b)
                return a;
            else return b;
        }

        private void addConstantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isImageLoad())
            {
                promptForm = new PromptForm(PromptForm.TypeDialog.Add);
                promptForm.ShowDialog();
                if (promptForm.Result != null)
                {
                    int addConst = Convert.ToInt32(promptForm.Result);
                    Bitmap img = new Bitmap(beforePictureBox.Image);
                    Bitmap newImg = new Bitmap(img.Width, img.Height);
                    for (int i = 0; i < img.Width; i++)
                    {
                        for (int j = 0; j < img.Height; j++)
                        {
                            newImg.SetPixel(i, j, Color.FromArgb(AddConst(img.GetPixel(i, j).R, addConst), AddConst(img.GetPixel(i, j).G, addConst), AddConst(img.GetPixel(i, j).B, addConst)));
                        }
                    }
                    afterPictureBox.Image = newImg;
                }
            }
            else MessageBox.Show("Изображение не загружено", "Ошибка");
        }
        private byte AddConst(byte value, int addConst)
        {
            if (value + addConst > 255)
                value = 255;
            else if (value + addConst < 0)
                value = 0;
            else value = (byte)(value + addConst);
            return value;
        }

        private void mulConstToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isImageLoad())
            {
                promptForm = new PromptForm(PromptForm.TypeDialog.Mul);
                promptForm.ShowDialog();
                if (promptForm.Result != null)
                {
                    double mulConst = Convert.ToDouble(promptForm.Result);
                    Bitmap img = new Bitmap(beforePictureBox.Image);
                    Bitmap newImg = new Bitmap(img.Width, img.Height);
                    for (int i = 0; i < img.Width; i++)
                    {
                        for (int j = 0; j < img.Height; j++)
                        {
                            newImg.SetPixel(i, j, Color.FromArgb(MulConst(img.GetPixel(i, j).R, mulConst), MulConst(img.GetPixel(i, j).G, mulConst), MulConst(img.GetPixel(i, j).B, mulConst)));
                        }
                    }
                    afterPictureBox.Image = newImg;
                }
            }
            else MessageBox.Show("Изображение не загружено", "Ошибка");
        }
        private byte MulConst(byte value, double mulConst)
        {
            if (value * mulConst > 255)
                value = 255;
            else value = (byte)(mulConst * value);
            return value;
        }

        private void negativToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isImageLoad())
            {
                Bitmap img = new Bitmap(beforePictureBox.Image);
                Bitmap newImg = new Bitmap(img.Width, img.Height);
                for (int i = 0; i < img.Width; i++)
                {
                    for (int j = 0; j < img.Height; j++)
                    {
                        newImg.SetPixel(i, j, Color.FromArgb(255-img.GetPixel(i, j).R, 255 - img.GetPixel(i, j).G, 255 - img.GetPixel(i, j).B));
                    }
                }
                afterPictureBox.Image = newImg;
            }
            else MessageBox.Show("Изображение не загружено", "Ошибка");
        }

        private void logToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isImageLoad())
            {
                promptForm = new PromptForm(PromptForm.TypeDialog.Log);
                promptForm.ShowDialog();
                if (promptForm.Result != null)
                {
                    double log = Convert.ToDouble(promptForm.Result);
                    Bitmap img = new Bitmap(beforePictureBox.Image);
                    Bitmap newImg = new Bitmap(img.Width, img.Height);
                    byte maxPixel = 0;
                    for (int i = 0; i < img.Width; i++)
                    {
                        for (int j = 0; j < img.Height; j++)
                        {

                            maxPixel = Max(maxPixel, img.GetPixel(i, j).R);
                            maxPixel = Max(maxPixel, img.GetPixel(i, j).G);
                            maxPixel = Max(maxPixel, img.GetPixel(i, j).B);
                        }
                    }
                    for (int i = 0; i < img.Width; i++)
                    {
                        for (int j = 0; j < img.Height; j++)
                        {
                            newImg.SetPixel(i, j, Color.FromArgb(Logarythm(img.GetPixel(i, j).R, log, maxPixel), Logarythm(img.GetPixel(i, j).G, log, maxPixel), Logarythm(img.GetPixel(i, j).B, log, maxPixel)));
                        }
                    }
                    afterPictureBox.Image = newImg;
                }
            }
            else MessageBox.Show("Изображение не загружено", "Ошибка");
        }
        private byte Logarythm(byte value, double log, byte maxColor)
        {
            return (byte)(255 * (Math.Log((log - 1) * value / (double)maxColor + 1, log))); 
        }

        private void powerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isImageLoad())
            {
                promptForm = new PromptForm(PromptForm.TypeDialog.Pow);
                promptForm.ShowDialog();
                if (promptForm.Result != null)
                {
                    double pow = Convert.ToDouble(promptForm.Result);
                    Bitmap img = new Bitmap(beforePictureBox.Image);
                    Bitmap newImg = new Bitmap(img.Width, img.Height);
                    byte maxPixel = 0;
                    for (int i = 0; i < img.Width; i++)
                    {
                        for (int j = 0; j < img.Height; j++)
                        {

                            maxPixel = Max(maxPixel, img.GetPixel(i, j).R);
                            maxPixel = Max(maxPixel, img.GetPixel(i, j).G);
                            maxPixel = Max(maxPixel, img.GetPixel(i, j).B);
                        }
                    }
                    for (int i = 0; i < img.Width; i++)
                    {
                        for (int j = 0; j < img.Height; j++)
                        {
                            newImg.SetPixel(i, j, Color.FromArgb(PowerConst(img.GetPixel(i, j).R, pow, maxPixel), PowerConst(img.GetPixel(i, j).G, pow, maxPixel), PowerConst(img.GetPixel(i, j).B, pow, maxPixel)));
                        }
                    }
                    afterPictureBox.Image = newImg;
                }
            }
            else MessageBox.Show("Изображение не загружено", "Ошибка");
        }

        private byte PowerConst(byte value, double pow, byte maxColor)
        {
            return (byte)(255 * (Math.Pow((double)value / (double)maxColor, pow)));
        }

        private void histCreateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isImageLoad())
            {
                int[] brighDistrib = new int[256];
                Bitmap img = new Bitmap(beforePictureBox.Image);
                for (int i = 0; i < img.Width; i++)
                {
                    for (int j = 0; j < img.Height; j++)
                    {
                        brighDistrib[img.GetPixel(i, j).R]++;
                        brighDistrib[img.GetPixel(i, j).G]++;
                        brighDistrib[img.GetPixel(i, j).B]++;
                    }
                }
                HistogramForm histogramForm = new HistogramForm(brighDistrib, img, this);
                histogramForm.Show();
            }
        }

        private void bitPlainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isImageLoad())
            {
                Bitmap img = new Bitmap(beforePictureBox.Image);
                BitPlainForm bitPlainForm = new BitPlainForm(img);
                bitPlainForm.ShowDialog();
            }
        }

        private void linearContrastToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isImageLoad())
            {
                Bitmap img = new Bitmap(beforePictureBox.Image);
                BitmapRawData bitmapRD = BitmapImageConverter.ConvertToRawDataFromImage(img);
                var rgbArray = new int[bitmapRD.RgbArray.Length];
                Array.Copy(bitmapRD.RgbArray, rgbArray, bitmapRD.RgbArray.Length);
                byte minColor = Byte.MaxValue;
                byte maxColor = byte.MinValue;
                for (int i = 0; i < rgbArray.Length; i++)
                {
                    if (minColor > rgbArray[i])
                        minColor = (byte)rgbArray[i];
                    if (maxColor < rgbArray[i])
                        maxColor = (byte)rgbArray[i];
                }
                double value = (double)255 / (maxColor - minColor);
                for (int i = 0; i < rgbArray.Length; i++)
                {
                    rgbArray[i] = (byte)(value * (rgbArray[i] - minColor));
                }
                var newBitmapRD = new BitmapRawData(rgbArray, bitmapRD.AlphaArray, bitmapRD.Width, bitmapRD.Height);
                afterPictureBox.Image = BitmapImageConverter.ConvertToImageFromRawData(newBitmapRD);
            }
        }

        private void histToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isImageLoad())
            {
                Bitmap img = new Bitmap(beforePictureBox.Image);
                BitmapRawData bitmapRD = BitmapImageConverter.ConvertToRawDataFromImage(img);
                var rgbArray = new int[bitmapRD.RgbArray.Length];
                Array.Copy(bitmapRD.RgbArray, rgbArray, bitmapRD.RgbArray.Length);
                int firstHalfSum = 0;
                byte firstHalfCount = 0;
                int secondHalfSum = 0;
                byte secondHalfCount = 0;
                byte initialThresh = 128;
                byte epsilon = 0;
                do
                {
                    for (int j = 0; j < rgbArray.Length; j++)
                    {
                        if (rgbArray[j] <= initialThresh)
                        {
                            firstHalfSum += rgbArray[j];
                            firstHalfCount++;
                        }
                        if (rgbArray[j] > initialThresh)
                        {
                            secondHalfSum += rgbArray[j];
                            secondHalfCount++;
                        }
                    }
                    
                    byte firstHalfAvg = firstHalfCount!=0?(byte)(firstHalfSum / firstHalfCount):(byte)0;
                    byte seconHalfAvg = secondHalfCount!=0?(byte)(secondHalfSum / secondHalfCount):(byte)0;
                    byte nextThresh = (byte)((firstHalfAvg + seconHalfAvg) / 2);
                    epsilon = (byte)Math.Abs((int)(nextThresh - initialThresh));
                    initialThresh = nextThresh;
                }
                while (epsilon > 1);
                for (int i = 0; i < rgbArray.Length; i++)
                {
                    if (rgbArray[i] > initialThresh) rgbArray[i] = 255;
                    else rgbArray[i] = 0;
                }
                var newBitmapRD = new BitmapRawData(rgbArray, bitmapRD.AlphaArray, bitmapRD.Width, bitmapRD.Height);
                afterPictureBox.Image = BitmapImageConverter.ConvertToImageFromRawData(newBitmapRD);
            }
        }

        interface IGetBrightness
        {
            int GetBrightness(Color pixel);
            Color SetBrightness(Color pixel, int value);
        }

        class GetRedBrightness : IGetBrightness
        {
            public int GetBrightness(Color pixel)
            {
                return pixel.R;
            }

            public Color SetBrightness(Color pixel, int value)
            {
                return Color.FromArgb(value, pixel.G, pixel.B);
            }
        }

        class GetGreenBrightness : IGetBrightness
        {
            public int GetBrightness(Color pixel)
            {
                return pixel.G;
            }
            public Color SetBrightness(Color pixel, int value)
            {
                return Color.FromArgb(pixel.R, value, pixel.B);
            }
        }

        class GetBlueBrightness : IGetBrightness
        {
            public int GetBrightness(Color pixel)
            {
                return pixel.B;
            }
            public Color SetBrightness(Color pixel, int value)
            {
                return Color.FromArgb(pixel.R, pixel.G, value);
            }
        }

        private void gradToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isImageLoad())
            {
                Bitmap img = new Bitmap(beforePictureBox.Image);
                img = ApplyThreshold(img, new GetRedBrightness());
                img = ApplyThreshold(img, new GetGreenBrightness());
                ApplyThreshold(img, new GetBlueBrightness());
                afterPictureBox.Image = img;
            }
        }

        Bitmap ApplyThreshold(Bitmap imageBitmap, IGetBrightness getBrightnessStrategy)
        {
            var threshold = GetThreshold(imageBitmap, getBrightnessStrategy);
            for (int i = 0; i < imageBitmap.Width; i++)
            {
                for (int j = 0; j < imageBitmap.Height; j++)
                {
                    var pixel = imageBitmap.GetPixel(i, j);
                    var brightness = getBrightnessStrategy.GetBrightness(pixel) > threshold ? 255 : 0;
                    pixel = getBrightnessStrategy.SetBrightness(pixel, brightness);
                    imageBitmap.SetPixel(i, j, pixel);
                }
            }
            return imageBitmap;
        }

        private int GetThreshold(Bitmap imageBitmap, IGetBrightness getBrightnessStrategy)
        {
            int gradientEnumerator = 0;
            int gradientDenumerator = 0;
            for (int i = 1; i < imageBitmap.Width - 1; i++)
            {
                for (int j = 1; j < imageBitmap.Height - 1; j++)
                {
                    var gradientTuple = CalculateGradientSum(
                        imageBitmap.GetPixel(i - 1, j), imageBitmap.GetPixel(i + 1, j),
                        imageBitmap.GetPixel(i, j + 1), imageBitmap.GetPixel(i, j - 1),
                        imageBitmap.GetPixel(i, j),
                        getBrightnessStrategy
                        );
                    gradientEnumerator += gradientTuple.Item1;
                    gradientDenumerator += gradientTuple.Item2;
                }
            }
            return (int)Math.Floor(gradientEnumerator/ (double)gradientDenumerator);
        }

        private Tuple<int, int> CalculateGradientSum(Color left, Color right, Color top, Color bottom, Color origin, IGetBrightness getBrightnessStrategy)
        {
            var brightnessTuple = CalculateBrightnessGradient(
                getBrightnessStrategy.GetBrightness(left), getBrightnessStrategy.GetBrightness(right),
                getBrightnessStrategy.GetBrightness(top), getBrightnessStrategy.GetBrightness(bottom),
                getBrightnessStrategy.GetBrightness(origin));
            return new Tuple<int, int>(brightnessTuple.Item1, brightnessTuple.Item2);
        }

        private Tuple<int, int> CalculateBrightnessGradient(int left, int right, int top, int bottom, int origin)
        {
            var gradient = Math.Max(Math.Abs(left - right), Math.Abs(top - bottom));
            return new Tuple<int, int>(origin * gradient, gradient);
        }

        private void otsuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isImageLoad())
            {
                Bitmap img = new Bitmap(beforePictureBox.Image);
                BitmapRawData bitmapRD = BitmapImageConverter.ConvertToRawDataFromImage(img);
                var rgbArray = new int[bitmapRD.RgbArray.Length];
                Array.Copy(bitmapRD.RgbArray, rgbArray, bitmapRD.RgbArray.Length);
                int min = rgbArray[0];
                int max = rgbArray[0];
                for (int i = 1; i < rgbArray.Length; i++)
                {
                    int value = rgbArray[i];
                    if (value < min) min = value;
                    if (value > max) max = value;
                }
                int histSize = max - min + 1;
                int[] hist = new int[histSize];
                for (int t = 0; t < histSize; t++) hist[t] = 0;
                for (int i = 0; i < rgbArray.Length; i++) hist[rgbArray[i] - min]++;
                int m = 0;
                int n = 0;
                for (int t = 0; t <= max - min; t++)
                {
                    m += t * hist[t];
                    n += hist[t];
                }
                float maxSigma = -1;
                int threshold = 0;
                int alpha1 = 0;
                int beta1 = 0;
                for (int t = 0; t < max - min; t++)
                {
                    alpha1 += t * hist[t];
                    beta1 += hist[t];
                    float w1 = (float)beta1 / n;
                    float a = (float)alpha1 / beta1 - (float)(m - alpha1) / (n - beta1);
                    float sigma = w1 * (1 - w1) * a * a;
                    if (sigma > maxSigma)
                    {
                        maxSigma = sigma;
                        threshold = t;
                    }
                }
                threshold += min;
                for (int i = 0; i < rgbArray.Length; i++)
                {
                    if (rgbArray[i] > threshold) rgbArray[i] = 255;
                    else rgbArray[i] = 0;
                }
                var newBitmapRD = new BitmapRawData(rgbArray, bitmapRD.AlphaArray, bitmapRD.Width, bitmapRD.Height);
                afterPictureBox.Image = BitmapImageConverter.ConvertToImageFromRawData(newBitmapRD);
            }
        }

        private void averageFilterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int[,] blurMatrix = new int[,]{ { 1, 1, 1 }, { 1, 1, 1 }, { 1, 1, 1 } };
            int[] rgb = new int[3];
            if (isImageLoad())
            {
                Bitmap img = new Bitmap(beforePictureBox.Image.Width, beforePictureBox.Image.Height);
                Bitmap oldImg = new Bitmap(beforePictureBox.Image);
                for (int i = 1; i < img.Width - 1; i++)
                {
                    for (int j = 1; j < img.Height - 1; j++)
                    {
                        rgb = Mask(blurMatrix, oldImg, i, j);
                        img.SetPixel(i,j, Color.FromArgb(rgb[0], rgb[1], rgb[2]));
                    }
                }
                afterPictureBox.Image = img;
            }
        }

        private int[] Mask(int[,] mask, Bitmap img, int x, int y)
        {
            int sum = 0;
            int[] rgb = new int[3]; 
            for (int i = 0; i < mask.GetLength(0); i++)
            {
                for (int j = 0; j < mask.GetLength(1); j++)
                {
                    sum += mask[i, j];
                }
            }
            rgb[0] = (CalculatePixel(mask, img, RGB.R, x, y)/sum);
            rgb[1] = (CalculatePixel(mask, img, RGB.G, x, y)/sum);
            rgb[2] = (CalculatePixel(mask, img, RGB.B, x, y)/sum);
            for (int i = 0; i < rgb.Length; i++)
            {
                if (rgb[i]>255)
                {
                    rgb[i] = 255;
                }
                else if (rgb[i]<0)
                {
                    rgb[i] = 0;
                }
            }
            return rgb;
        } 

        private int CalculatePixel(int[,] mask, Bitmap img, RGB enumRGB, int x, int y)
        {
            int resultColor = 0;
            switch (enumRGB)
            {
                case RGB.R:
                    resultColor = mask[1, 0] * img.GetPixel(x, y - 1).R + mask[1, 2] * img.GetPixel(x, y + 1).R
                        + mask[0, 1] * img.GetPixel(x - 1, y).R + mask[2, 1] * img.GetPixel(x + 1, y).R
                        + mask[0, 0] * img.GetPixel(x - 1, y - 1).R + mask[2, 0] * img.GetPixel(x + 1, y - 1).R
                        + mask[0, 2] * img.GetPixel(x - 1, y + 1).R + mask[2, 2] * img.GetPixel(x + 1, y + 1).R
                        + mask[1, 1] * img.GetPixel(x, y).R;
                    break;
                case RGB.B:
                    resultColor = mask[1, 0] * img.GetPixel(x, y - 1).B + mask[1, 2] * img.GetPixel(x, y + 1).B
                        + mask[0, 1] * img.GetPixel(x - 1, y).B + mask[2, 1] * img.GetPixel(x + 1, y).B
                        + mask[0, 0] * img.GetPixel(x - 1, y - 1).B + mask[2, 0] * img.GetPixel(x + 1, y - 1).B
                        + mask[0, 2] * img.GetPixel(x - 1, y + 1).B + mask[2, 2] * img.GetPixel(x + 1, y + 1).B
                        + mask[1, 1] * img.GetPixel(x, y).B;
                    break;
                case RGB.G:
                    resultColor = mask[1, 0] * img.GetPixel(x, y - 1).G + mask[1, 2] * img.GetPixel(x, y + 1).G
                        + mask[0, 1] * img.GetPixel(x - 1, y).G + mask[2, 1] * img.GetPixel(x + 1, y).G
                        + mask[0, 0] * img.GetPixel(x - 1, y - 1).G + mask[2, 0] * img.GetPixel(x + 1, y - 1).G
                        + mask[0, 2] * img.GetPixel(x - 1, y + 1).G + mask[2, 2] * img.GetPixel(x + 1, y + 1).G
                        + mask[1, 1] * img.GetPixel(x, y).G;
                    break;
            }
            return resultColor;
        }

        private void gaussFilterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int[,] blurMatrix = new int[,] { { 1, 4, 1 }, { 4, 12, 4 }, { 1, 4, 1 } };
            int[] rgb = new int[3];
            if (isImageLoad())
            {
                Bitmap img = new Bitmap(beforePictureBox.Image.Width, beforePictureBox.Image.Height);
                Bitmap oldImg = new Bitmap(beforePictureBox.Image);
                for (int i = 1; i < img.Width - 1; i++)
                {
                    for (int j = 1; j < img.Height - 1; j++)
                    {
                        rgb = Mask(blurMatrix, oldImg, i, j);
                        img.SetPixel(i, j, Color.FromArgb(rgb[0], rgb[1], rgb[2]));
                    }
                }
                afterPictureBox.Image = img;
            }
        }

        private void laplassianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int[,] sharpeningMatrix = new int[,] { { 0, -1, 0 }, { -1, 5, -1 }, { 0, -1, 0 } };
            int[] rgb = new int[3];
            if (isImageLoad())
            {
                Bitmap img = new Bitmap(beforePictureBox.Image.Width, beforePictureBox.Image.Height);
                Bitmap oldImg = new Bitmap(beforePictureBox.Image);
                for (int i = 1; i < img.Width - 1; i++)
                {
                    for (int j = 1; j < img.Height - 1; j++)
                    {
                        rgb = Mask(sharpeningMatrix, oldImg, i, j);
                        img.SetPixel(i, j, Color.FromArgb(rgb[0], rgb[1], rgb[2]));
                    }
                }
                afterPictureBox.Image = img;
            }
        }

        private enum FilterType
        {
            Median,
            Maximum,
            Minimum,
            WeightMedian
        }

        private void unsharpMaskingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int[,] sharpeningMatrix = new int[,] { { -1, -1, -1 }, { -1, 20, -1 }, { -1, -1, -1 } };
            int[] rgb = new int[3];
            if (isImageLoad())
            {
                Bitmap img = new Bitmap(beforePictureBox.Image.Width, beforePictureBox.Image.Height);
                Bitmap oldImg = new Bitmap(beforePictureBox.Image);
                for (int i = 1; i < img.Width - 1; i++)
                {
                    for (int j = 1; j < img.Height - 1; j++)
                    {
                        rgb = Mask(sharpeningMatrix, oldImg, i, j);
                        img.SetPixel(i, j, Color.FromArgb(rgb[0], rgb[1], rgb[2]));
                    }
                }
                afterPictureBox.Image = img;
            }
        }

        private void medianFilterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isImageLoad())
            {
                int[] rgb = new int[3];
                Bitmap img = new Bitmap(beforePictureBox.Image.Width, beforePictureBox.Image.Height);
                Bitmap oldImg = new Bitmap(beforePictureBox.Image);
                for (int i = 1; i < img.Width - 1; i++)
                {
                    for (int j = 1; j < img.Height - 1; j++)
                    {
                        rgb = Median(oldImg, i, j, FilterType.Median);
                        img.SetPixel(i, j, Color.FromArgb(rgb[0], rgb[1], rgb[2]));
                    }
                }
                afterPictureBox.Image = img;
            }

        }

        private int[] Median(Bitmap img, int x, int y, FilterType filterType)
        {
            
            int[] rgb = new int[3];
            rgb[0] = CalculatePixel(img, RGB.R, x, y, filterType);
            rgb[1] = CalculatePixel(img, RGB.G, x, y, filterType);
            rgb[2] = CalculatePixel(img, RGB.B, x, y, filterType);
            return rgb;
        }

        private int CalculatePixel(Bitmap img, RGB enumRGB, int x, int y, FilterType filterType)
        {
            List<int> windowCoeff = new List<int>();
            if (filterType == FilterType.WeightMedian)
            {
                switch (enumRGB)
                {
                    case RGB.R:
                        windowCoeff.Add(img.GetPixel(x, y).R);
                        windowCoeff.Add(img.GetPixel(x, y).R);
                        windowCoeff.Add(img.GetPixel(x, y).R);
                        windowCoeff.Add(img.GetPixel(x - 1, y).R);
                        windowCoeff.Add(img.GetPixel(x - 1, y).R);
                        windowCoeff.Add(img.GetPixel(x + 1, y).R);
                        windowCoeff.Add(img.GetPixel(x + 1, y).R);
                        windowCoeff.Add(img.GetPixel(x, y - 1).R);
                        windowCoeff.Add(img.GetPixel(x, y + 1).R);
                        break;
                    case RGB.G:
                        windowCoeff.Add(img.GetPixel(x, y).G);
                        windowCoeff.Add(img.GetPixel(x, y).G);
                        windowCoeff.Add(img.GetPixel(x, y).G);
                        windowCoeff.Add(img.GetPixel(x - 1, y).G);
                        windowCoeff.Add(img.GetPixel(x - 1, y).G);
                        windowCoeff.Add(img.GetPixel(x + 1, y).G);
                        windowCoeff.Add(img.GetPixel(x + 1, y).G);
                        windowCoeff.Add(img.GetPixel(x, y - 1).G);
                        windowCoeff.Add(img.GetPixel(x, y + 1).G);
                        break;
                    case RGB.B:
                        windowCoeff.Add(img.GetPixel(x, y).B);
                        windowCoeff.Add(img.GetPixel(x, y).B);
                        windowCoeff.Add(img.GetPixel(x, y).B);
                        windowCoeff.Add(img.GetPixel(x - 1, y).B);
                        windowCoeff.Add(img.GetPixel(x - 1, y).B);
                        windowCoeff.Add(img.GetPixel(x + 1, y).B);
                        windowCoeff.Add(img.GetPixel(x + 1, y).B);
                        windowCoeff.Add(img.GetPixel(x, y - 1).B);
                        windowCoeff.Add(img.GetPixel(x, y + 1).B);
                        break;
                }
            }
            else
            {
                switch (enumRGB)
                {
                    case RGB.R:
                        windowCoeff.Add(img.GetPixel(x, y).R);
                        windowCoeff.Add(img.GetPixel(x - 1, y).R);
                        windowCoeff.Add(img.GetPixel(x + 1, y).R);
                        windowCoeff.Add(img.GetPixel(x, y - 1).R);
                        windowCoeff.Add(img.GetPixel(x, y + 1).R);
                        windowCoeff.Add(img.GetPixel(x - 1, y - 1).R);
                        windowCoeff.Add(img.GetPixel(x + 1, y + 1).R);
                        windowCoeff.Add(img.GetPixel(x - 1, y + 1).R);
                        windowCoeff.Add(img.GetPixel(x + 1, y - 1).R);
                        break;
                    case RGB.G:
                        windowCoeff.Add(img.GetPixel(x, y).G);
                        windowCoeff.Add(img.GetPixel(x - 1, y).G);
                        windowCoeff.Add(img.GetPixel(x + 1, y).G);
                        windowCoeff.Add(img.GetPixel(x, y - 1).G);
                        windowCoeff.Add(img.GetPixel(x, y + 1).G);
                        windowCoeff.Add(img.GetPixel(x - 1, y - 1).G);
                        windowCoeff.Add(img.GetPixel(x + 1, y + 1).G);
                        windowCoeff.Add(img.GetPixel(x - 1, y + 1).G);
                        windowCoeff.Add(img.GetPixel(x + 1, y - 1).G);
                        break;
                    case RGB.B:
                        windowCoeff.Add(img.GetPixel(x, y).B);
                        windowCoeff.Add(img.GetPixel(x - 1, y).B);
                        windowCoeff.Add(img.GetPixel(x + 1, y).B);
                        windowCoeff.Add(img.GetPixel(x, y - 1).B);
                        windowCoeff.Add(img.GetPixel(x, y + 1).B);
                        windowCoeff.Add(img.GetPixel(x - 1, y - 1).B);
                        windowCoeff.Add(img.GetPixel(x + 1, y + 1).B);
                        windowCoeff.Add(img.GetPixel(x - 1, y + 1).B);
                        windowCoeff.Add(img.GetPixel(x + 1, y - 1).B);
                        break;
                }
            }
            windowCoeff.Sort();
            switch (filterType)
            {
                case FilterType.Median:
                    return windowCoeff[windowCoeff.Count / 2];
                case FilterType.Maximum:
                    return windowCoeff[windowCoeff.Count - 1];
                case FilterType.Minimum:
                    return windowCoeff[0];
                default:
                    return windowCoeff[windowCoeff.Count / 2];
            }
            
        }

        private void maxFilterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isImageLoad())
            {
                int[] rgb = new int[3];
                Bitmap img = new Bitmap(beforePictureBox.Image.Width, beforePictureBox.Image.Height);
                Bitmap oldImg = new Bitmap(beforePictureBox.Image);
                for (int i = 1; i < img.Width - 1; i++)
                {
                    for (int j = 1; j < img.Height - 1; j++)
                    {
                        rgb = Median(oldImg, i, j, FilterType.Maximum);
                        img.SetPixel(i, j, Color.FromArgb(rgb[0], rgb[1], rgb[2]));
                    }
                }
                afterPictureBox.Image = img;
            }
        }

        private void minFilterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isImageLoad())
            {
                int[] rgb = new int[3];
                Bitmap img = new Bitmap(beforePictureBox.Image.Width, beforePictureBox.Image.Height);
                Bitmap oldImg = new Bitmap(beforePictureBox.Image);
                for (int i = 1; i < img.Width - 1; i++)
                {
                    for (int j = 1; j < img.Height - 1; j++)
                    {
                        rgb = Median(oldImg, i, j, FilterType.Minimum);
                        img.SetPixel(i, j, Color.FromArgb(rgb[0], rgb[1], rgb[2]));
                    }
                }
                afterPictureBox.Image = img;
            }
        }

        private void weightMedianFilterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isImageLoad())
            {
                int[] rgb = new int[3];
                Bitmap img = new Bitmap(beforePictureBox.Image.Width, beforePictureBox.Image.Height);
                Bitmap oldImg = new Bitmap(beforePictureBox.Image);
                for (int i = 1; i < img.Width - 1; i++)
                {
                    for (int j = 1; j < img.Height - 1; j++)
                    {
                        rgb = Median(oldImg, i, j, FilterType.WeightMedian);
                        img.SetPixel(i, j, Color.FromArgb(rgb[0], rgb[1], rgb[2]));
                    }
                }
                afterPictureBox.Image = img;
            }
        }

        private void findPointsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isImageLoad())
            {
                Bitmap oldImg = new Bitmap(beforePictureBox.Image);   
                afterPictureBox.Image = new PointFilterConversion().Convert(oldImg);
            }
        }

        private void обнаружениеЛинийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap oldImg = new Bitmap(beforePictureBox.Image);
            afterPictureBox.Image = new LineFilterConversion().Convert(oldImg);
        }

        private void edgeFindToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap oldImg = new Bitmap(beforePictureBox.Image);
            afterPictureBox.Image = new EdgeFilterConversion().Convert(oldImg);
        }
    }
}
