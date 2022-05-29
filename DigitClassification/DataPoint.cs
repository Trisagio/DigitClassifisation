using System;

namespace DigitClassification
{
    public class DataPoint
    {
        public double[] Point { get; private set; }
        public string Class { get; private set; }

        private DataPoint(double[] point, string numClass)
        {
            Point = point;
            Class = numClass;
        }

        public static DataPoint Create(double[] point, string numClass)
        {
            if (point == null || numClass == null)
                throw new ArgumentException("Неккоректный аргумент!");

            return new DataPoint(point, numClass);
        }
    }
}
