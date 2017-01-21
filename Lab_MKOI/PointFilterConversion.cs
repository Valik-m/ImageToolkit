using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Drawing;

namespace Lab_MKOI
{
    class PointFilterConversion
    {
        private readonly int[,] _mask = { { -1, -1, -1 }, { -1, 8, -1 }, { -1, -1, -1 } };
        public static int Threshold = 50;

        public PointFilterConversion()
        { }

        public Bitmap Convert(Bitmap imageBitmap)
        {
            Bitmap img = new Bitmap(imageBitmap.Width, imageBitmap.Height);
            for (int i = 1; i < img.Width - 1; i++)
            {
                for (int j = 1; j < img.Height - 1; j++)
                {
                    var rgb = Mask(imageBitmap, i, j);
                    img.SetPixel(i, j, Color.FromArgb(rgb[0], rgb[1], rgb[2]));
                }
            }
            return img;
        }

        private int[] Mask(Bitmap imageBitmap, int x, int y)
        {
            int[] rgb = new int[3];
            rgb[0] = (_mask[1, 0] * imageBitmap.GetPixel(x, y - 1).R + _mask[1, 2] * imageBitmap.GetPixel(x, y + 1).R
                        + _mask[0, 1] * imageBitmap.GetPixel(x - 1, y).R + _mask[2, 1] * imageBitmap.GetPixel(x + 1, y).R
                        + _mask[0, 0] * imageBitmap.GetPixel(x - 1, y - 1).R + _mask[2, 0] * imageBitmap.GetPixel(x + 1, y - 1).R
                        + _mask[0, 2] * imageBitmap.GetPixel(x - 1, y + 1).R + _mask[2, 2] * imageBitmap.GetPixel(x + 1, y + 1).R
                        + _mask[1, 1] * imageBitmap.GetPixel(x, y).R);
            rgb[1] = (_mask[1, 0] * imageBitmap.GetPixel(x, y - 1).G + _mask[1, 2] * imageBitmap.GetPixel(x, y + 1).G
                        + _mask[0, 1] * imageBitmap.GetPixel(x - 1, y).G + _mask[2, 1] * imageBitmap.GetPixel(x + 1, y).G
                        + _mask[0, 0] * imageBitmap.GetPixel(x - 1, y - 1).G + _mask[2, 0] * imageBitmap.GetPixel(x + 1, y - 1).G
                        + _mask[0, 2] * imageBitmap.GetPixel(x - 1, y + 1).G + _mask[2, 2] * imageBitmap.GetPixel(x + 1, y + 1).G
                        + _mask[1, 1] * imageBitmap.GetPixel(x, y).G);
            rgb[2] = (_mask[1, 0] * imageBitmap.GetPixel(x, y - 1).B + _mask[1, 2] * imageBitmap.GetPixel(x, y + 1).B
                        + _mask[0, 1] * imageBitmap.GetPixel(x - 1, y).B + _mask[2, 1] * imageBitmap.GetPixel(x + 1, y).B
                        + _mask[0, 0] * imageBitmap.GetPixel(x - 1, y - 1).B + _mask[2, 0] * imageBitmap.GetPixel(x + 1, y - 1).B
                        + _mask[0, 2] * imageBitmap.GetPixel(x - 1, y + 1).B + _mask[2, 2] * imageBitmap.GetPixel(x + 1, y + 1).B
                        + _mask[1, 1] * imageBitmap.GetPixel(x, y).B);

            for (int i = 0; i < rgb.Length; i++)
            {
                if (Math.Abs(rgb[i]) <= Threshold)
                {
                    rgb[i] = 0;
                }
                else
                {
                    rgb[i] += 100;
                }
                rgb[i] = rgb[i] > 255 ? 255 : rgb[i];
                rgb[i] = rgb[i] < 0 ? 0 : rgb[i];
            }
            return rgb;
        }
    }
}
