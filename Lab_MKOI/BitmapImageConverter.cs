using System;
using System.Drawing;

namespace Lab_MKOI
{
    public class BitmapRawData
    {
        public BitmapRawData(int[] rgbArray, int[] alphaArray, int width, int height)
        {
            RgbArray = rgbArray;
            AlphaArray = alphaArray;
            Width = width;
            Height = height;
        }

        public int Width { get; set; }

        public int Height { get; set; }

        public int[] RgbArray { get; set; }

        public int[] AlphaArray { get; set; }
    }

    public class BitmapImageConverter
    {
        public static BitmapRawData ConvertToRawDataFromImage(Bitmap image)
        {
            int[] rgbArray = new int[3*image.Width*image.Height];
            int[] alphaArray = new int[image.Width*image.Height];
            int rgbIndex = 0;
            int alphaIndex = 0;
            for (int x = 0; x < image.Width; x++)
            {
                for (int y = 0; y < image.Height; y++)
                {
                    Color pixelColor = image.GetPixel(x, y);
                    rgbArray[rgbIndex++] = pixelColor.R;
                    rgbArray[rgbIndex++] = pixelColor.G;
                    rgbArray[rgbIndex++] = pixelColor.B;
                    alphaArray[alphaIndex++] = pixelColor.A;
                }
            }
        
            return new BitmapRawData(rgbArray, alphaArray, image.Width, image.Height);
        }

        public static Bitmap ConvertToImageFromRawData(BitmapRawData imageRawData)
        {
            var rgbArray = imageRawData.RgbArray;
            var alphaArray = imageRawData.AlphaArray;

            Bitmap image = new Bitmap(imageRawData.Width, imageRawData.Height);
            int alphaIndex = 0;
            int rgbIndex = 0;
            for (int x = 0; x < imageRawData.Width; x++)
            {
                for (int y = 0; y < imageRawData.Height; y++)
                {
                    int r = rgbArray[rgbIndex++];
                    int g = rgbArray[rgbIndex++];
                    int b = rgbArray[rgbIndex++];
                    int a = alphaArray[alphaIndex++];
                    image.SetPixel(x, y, Color.FromArgb(a, r, g, b));
                }
            }
            return image;
        }
    }
}
