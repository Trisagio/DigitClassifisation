using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace DigitClassification
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

        public static Bitmap DataToBitmap(byte[] data)
        {
            Bitmap bmp = new Bitmap(28, 28, PixelFormat.Format8bppIndexed);
            // Accord filters and Accord BlobCounter() uses the following formats:
            // Format8bppIndexed
            // Format24bppRgb
            // Format32bppRgb

            BitmapData bmpData = bmp.LockBits(
                                 new Rectangle(0, 0, bmp.Width, bmp.Height),
                                 ImageLockMode.WriteOnly, bmp.PixelFormat);
            Marshal.Copy(data, 0, bmpData.Scan0, data.Length);
            bmp.UnlockBits(bmpData);

            return bmp;
        }
    }
}