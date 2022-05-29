using System;
using System.Collections.Generic;
using System.Text;

namespace DigitClassification.Common
{
    public static class DoubleArrayExtensions
    {
        public static string CreateString(this double[,] matrix)
        {
            StringBuilder sb = new StringBuilder();

            matrix.ForEachElement(element => sb.Append(element), () => sb.AppendLine());
            return sb.ToString();
        }

        public static double[] Flatten(this double[,] matrix)
        {
            List<double> flattenMatrix = new List<double>();

            matrix.ForEachElement(element => flattenMatrix.Add(element));
            return flattenMatrix.ToArray();
        }

        public static void ForEachElement(this double[,] matrix, Action<double> onElementAction, Action onNewRowAction = null)
        {
            for (int y = 0; y < matrix.GetLength(1); y++)
            {
                for (int x = 0; x < matrix.GetLength(0); x++)
                    onElementAction(matrix[x, y]);

                onNewRowAction?.Invoke();
            }
        }
    }
}
