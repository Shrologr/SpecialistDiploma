using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfDiploma
{
    public struct StatisticsData 
    {
        public double MeanSum { get; set; }
        public double RootMeanSquareSum { get; set; }
        public double Entropy { get; set; }
        public double Intensity { get; set; }
        public double MaxEntropy { get; set; }
    }
    public class GridStatistics
    {
        public List<List<float>> cells;
        public int totalCellCount;
        public double cellWidth;
        public GridStatistics()
        {
            cells = new List<List<float>>();
        }
        public void ConstructGrid(Derives derives)
        {
            totalCellCount = 0;
            cells.Clear();
            cells.AddRange(new List<float>[(int)(derives.A * 2 / cellWidth) + (((derives.A * 2) % cellWidth != 0) ? 1 : 0)]);
            for (int i = 0; i < cells.Count; i++)
            {
                cells[i] = new List<float>();
                cells[i].AddRange(new float[(int)(derives.A / cellWidth) + ((derives.A % cellWidth != 0) ? 1 : 0)]);
                for (int j = 0; j < cells[i].Count; j++)
                {
                    if (Math.Sqrt(Math.Pow(i * cellWidth - derives.A, 2) + Math.Pow(j * cellWidth, 2)) > derives.A && Math.Sqrt(Math.Pow((i + 1) * cellWidth - derives.A, 2) + Math.Pow(j * cellWidth, 2)) > derives.A)
                    {
                        cells[i].RemoveRange(j, cells[i].Count - j);
                        break;
                    }
                    totalCellCount++;
                }
            }
        }

        public StatisticsData CalculateValues()
        {
            StatisticsData data = new StatisticsData();
            for (int j = 0; j < cells.Count; j++)
            {
                for (int k = 0; k < cells[j].Count; k++)
                {
                    data.MeanSum += cells[j][k];
                    data.RootMeanSquareSum += Math.Pow(cells[j][k], 2);
                    data.Entropy += cells[j][k] * ((cells[j][k] == 0) ? 1 : Math.Log(cells[j][k]));
                }
            }
            data.RootMeanSquareSum /= totalCellCount;
            data.Entropy /= -totalCellCount;
            data.MeanSum /= totalCellCount;

            for (int j = 0; j < cells.Count; j++)
            {
                for (int k = 0; k < cells[j].Count; k++)
                {
                    data.Intensity += Math.Pow(cells[j][k] - data.MeanSum, 2);
                }
            }
            data.Intensity /= totalCellCount;
            data.Intensity /= data.MeanSum * (1 - data.MeanSum);
            data.MaxEntropy = -data.MeanSum * Math.Log(data.MeanSum);
            data.MeanSum = Math.Pow(data.MeanSum, 2);
            return data;
        }

        public void ClearGrid()
        {
            for (int j = 0; j < cells.Count; j++)
            {
                for (int k = 0; k < cells[j].Count; k++)
                {
                    cells[j][k] = 0;
                }
            }
        }
    }
}
