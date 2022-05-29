using System.Drawing;
using System.Drawing.Imaging;

using Accord.Imaging.Filters;

namespace DigitClassification.Common
{
    public static class BitmapExtensions
    {
        public static double[,] CreateMatrix(this Bitmap image, double threshold)
        {
            var _matrix = new double[image.Width, image.Height];

            for (int y = 0; y < image.Height; y++)
            {
                for (int x = 0; x < image.Width; x++)
                {
                    var brightness = image.GetPixel(x, y).GetBrightness();

                    if (brightness < threshold)
                        _matrix[x, y] = 0.0;
                    else _matrix[x, y] = 1.0;
                }
            }

            return _matrix;
        }
    }
}
