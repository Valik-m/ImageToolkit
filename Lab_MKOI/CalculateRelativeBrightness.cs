using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_MKOI
{
    public class CalculateRelativeBrightness
    {
        public static int[] Calculate(int[] rgbArray)
        {
            var result = new int[rgbArray.Length];
            for (int i = 0; i < result.Length/3; i++)
            {
                result[3*i] = (rgbArray[3*i] + rgbArray[3*i + 1] + rgbArray[3*i + 2])/3;
                result[3*i + 1] = (rgbArray[3 * i] + rgbArray[3 * i + 1] + rgbArray[3 * i + 2]) / 3;
                result[3*i + 2] = (rgbArray[3 * i] + rgbArray[3 * i + 1] + rgbArray[3 * i + 2]) / 3;
            }
            return result;
        }
    }
}
