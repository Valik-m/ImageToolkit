using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_MKOI
{
    static class Filters
    {
        private static int[,] blurMatrix = new int[,] { { 1, 1, 1 }, { 1, 1, 1 }, { 1, 1, 1 } };
        private static int[,] gaussBlurMatrix = new int[,] {  { 1, 4, 1 }, { 4, 12, 4 }, { 1, 4, 1 } };
        private static int[,] sharpeningLaplassMatrix = new int[,] { { -1, -1, -1 }, { -1, 9, -1 }, { -1, -1, -1 } };
        public static Bitmap averageFilter(Bitmap oldImg)
        {
            Bitmap img = CalculateFilter(oldImg, blurMatrix);
            return img;
        }

        public static Bitmap gaussFilter(Bitmap oldImg)
        {
            Bitmap img = CalculateFilter(oldImg, gaussBlurMatrix);
            return img;
        }

        public static Bitmap laplassianFilter(Bitmap oldImg)
        {
            Bitmap img = CalculateFilter(oldImg, sharpeningLaplassMatrix);
            return img;
        }
        private static Bitmap CalculateFilter(Bitmap oldImg, int[,] mask)
        {
            int[] rgb = new int[3];
            Bitmap img = new Bitmap(oldImg.Width, oldImg.Height);
            for (int i = 1; i < img.Width - 1; i++)
            {
                for (int j = 1; j < img.Height - 1; j++)
                {
                    rgb = Mask(mask, img, i, j);
                    img.SetPixel(i, j, Color.FromArgb(rgb[0], rgb[1], rgb[2]));
                }
            }
            return img;
        } 

        private static int[] Mask(int[,] mask, Bitmap img, int x, int y)
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
            rgb[0] = (mask[1, 0] * img.GetPixel(x, y - 1).R + mask[1, 2] * img.GetPixel(x, y + 1).R
                        + mask[0, 1] * img.GetPixel(x - 1, y).R + mask[2, 1] * img.GetPixel(x + 1, y).R
                        + mask[0, 0] * img.GetPixel(x - 1, y - 1).R + mask[2, 0] * img.GetPixel(x + 1, y - 1).R
                        + mask[0, 2] * img.GetPixel(x - 1, y + 1).R + mask[2, 2] * img.GetPixel(x + 1, y + 1).R
                        + mask[1, 1] * img.GetPixel(x, y).R) / sum;
            rgb[1] = (mask[1, 0] * img.GetPixel(x, y - 1).G + mask[1, 2] * img.GetPixel(x, y + 1).G
                        + mask[0, 1] * img.GetPixel(x - 1, y).G + mask[2, 1] * img.GetPixel(x + 1, y).G
                        + mask[0, 0] * img.GetPixel(x - 1, y - 1).G + mask[2, 0] * img.GetPixel(x + 1, y - 1).G
                        + mask[0, 2] * img.GetPixel(x - 1, y + 1).G + mask[2, 2] * img.GetPixel(x + 1, y + 1).G
                        + mask[1, 1] * img.GetPixel(x, y).G) / sum;
            rgb[2] = (mask[1, 0] * img.GetPixel(x, y - 1).B + mask[1, 2] * img.GetPixel(x, y + 1).B
                        + mask[0, 1] * img.GetPixel(x - 1, y).B + mask[2, 1] * img.GetPixel(x + 1, y).B
                        + mask[0, 0] * img.GetPixel(x - 1, y - 1).B + mask[2, 0] * img.GetPixel(x + 1, y - 1).B
                        + mask[0, 2] * img.GetPixel(x - 1, y + 1).B + mask[2, 2] * img.GetPixel(x + 1, y + 1).B
                        + mask[1, 1] * img.GetPixel(x, y).B) / sum;

            for (int i = 0; i < rgb.Length; i++)
            {
                if (rgb[i] > 255)
                {
                    rgb[i] = 255;
                }
                else if (rgb[i] < 0)
                {
                    rgb[i] = 0;
                }
            }
            return rgb;
        }
    }
}
