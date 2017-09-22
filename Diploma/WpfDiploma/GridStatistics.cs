using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfDiploma
{
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

        public void CalculateValues(ref double meanSum, ref double rootMeanSquareSum, ref double entropy, ref double maxEntropy, ref double intensity)
        {
            for (int j = 0; j < cells.Count; j++)
            {
                for (int k = 0; k < cells[j].Count; k++)
                {
                    meanSum += cells[j][k];
                    rootMeanSquareSum += Math.Pow(cells[j][k], 2);
                    entropy += cells[j][k] * ((cells[j][k] == 0) ? 1 : Math.Log(cells[j][k]));
                }
            }
            rootMeanSquareSum /= totalCellCount;
            entropy /= -totalCellCount;
            meanSum /= totalCellCount;

            for (int j = 0; j < cells.Count; j++)
            {
                for (int k = 0; k < cells[j].Count; k++)
                {
                    intensity += Math.Pow(cells[j][k] - meanSum, 2);
                }
            }
            intensity /= totalCellCount;
            intensity /= meanSum * (1 - meanSum);
            maxEntropy = -meanSum * Math.Log(meanSum);
            meanSum = Math.Pow(meanSum, 2);
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
