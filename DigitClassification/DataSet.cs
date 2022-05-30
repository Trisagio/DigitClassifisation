using System;
using System.Collections.Generic;

namespace DigitClassification
{
    internal class DataSet
    {
        private List<DataPoint> _dataSet = new List<DataPoint>();

        internal void Add(DataPoint dataPoint)
        {
            if (_dataSet.Count == 60000) return;

            _dataSet.Add(dataPoint);
        }

        internal void Clear()
        {
            if (_dataSet == null) return;

            _dataSet.Clear();
        }

        internal string Predict(double[] vector, Func<double[], double[], double> distFunc)
        {
            double smallestDist = Double.MaxValue;
            int min = Int32.MaxValue;

            for (int i = 0; i < _dataSet.Count; i++)
            {
                var distance = distFunc(_dataSet[i].Point, vector);

                if (distance < smallestDist)
                {
                    smallestDist = distance;
                    min = i;
                }
            }

            return _dataSet[min].Class;
        }

        public static DataSet New() => new DataSet();
    }
}
