using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;

namespace Tyuiu.IvanovJD.Sprint7.Project.V2.Lib
{
    public class DataService
    {
        public double MaxCena(string[,] path)
        {
            double max = 0;
            int columnIndex = 6;
            for (int i = 1; i < path.GetLength(0); i++)
            {
                if (Convert.ToDouble(path[i, columnIndex]) > max)
                {
                    max = Convert.ToDouble(path[i, columnIndex]);
                }
            }
            return max;
        }
        public double MixCena(string[,] path)
        {
            double min = 9999;
            int columnIndex = 6;
            for (int i = 1; i < path.GetLength(0); i++)
            {
                if (Convert.ToDouble(path[i, columnIndex]) < min)
                {
                    min = Convert.ToDouble(path[i, columnIndex]);
                }
            }
            return min;
        }

        public double SredCena(string[,] path)
        {
            double sum = 0;
            for (int i = 1; i < path.GetLength(0); i++)
            {
                sum += Convert.ToDouble(path[i, 6]);
            }
            double average = sum / (path.GetLength(0) - 1);
            return Math.Round(average, 2);
        }
    }
}
