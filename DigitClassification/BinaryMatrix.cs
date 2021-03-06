using System;
using System.Drawing;

namespace DigitClassification
{
    internal class BinaryMatrix
    {
        private double[,] _matrix;

        private BinaryMatrix() { }

        private BinaryMatrix(Bitmap image, double threshold)
            => _matrix = image.CreateMatrix(threshold);

        public void Flatten(Action<double[]> onValid)
        {
            if (_matrix == null) return;

            onValid(_matrix.Flatten());
        }

        public static BinaryMatrix Create(Bitmap image, double threshold)
            => new BinaryMatrix(image, threshold);

        public static BinaryMatrix Empty() => new BinaryMatrix();
    }
}