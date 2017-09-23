using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace WpfDiploma
{
    [Serializable]
    public class Derives
    {
        public double V;
        public double U; 
        public double A;
        public double Period;
        public const double Pi = 3.14159265358979323846;
        public Derives()
        {
            V = 0;
            U = 0;
            A = 0;
            Period = 0.1;
        }

        public bool SetData(string straightSpeed, string rotatingSpeed, string radius, string workPeriod)
        {
            if (double.TryParse(straightSpeed, NumberStyles.Float, CultureInfo.InvariantCulture, out V) &&
                double.TryParse(rotatingSpeed, NumberStyles.Float, CultureInfo.InvariantCulture, out U) &&
                double.TryParse(radius, NumberStyles.Float, CultureInfo.InvariantCulture, out A) &&
                double.TryParse(workPeriod, NumberStyles.Float, CultureInfo.InvariantCulture, out Period))
            {
                V /= A;
                U /= A;
                A /= A;
                return true;
            }
            else
                return false;
        }

        public void SetData(double straightSpeed, double rotatingSpeed, double radius, double workPeriod)
        {
            V = straightSpeed / radius;
            U = rotatingSpeed / radius;
            A = 1;
            Period = workPeriod;
        }

        public Derives(double v, double u, double a, double period)
        {
            V = v;
            U = u;
            A = a;
            Period = period;
        }

        public double PsiA(double x, double y)
        {
            return (2 * V) / (Pi * Pi - 4) * ((Pi * (A * A - x * x - y * y) + 4 * A * y) / (2 * A) * Math.Atan((2 * A * y) / (A * A - x * x - y * y))
               - Pi * y);
        }



        public double DpsiADy(double x, double y)
        {
            return (2 * V) / (Pi * Pi - 4) * ((-Pi * y + 2 * A) / (A) * Math.Atan((2 * A * y) / (A * A - x * x - y * y))
                + ((A * A - x * x + y * y)) / (4 * A * A * y * y + Math.Pow((A * A - x * x - y * y), 2))
                * (Pi * (A * A - x * x - y * y) + 4 * A * y) - Pi);
        }

        public double DpsiADx(double x, double y)
        {
            return (2 * V) / (Pi * Pi - 4) * ((-Pi * x) / (A) * Math.Atan((2 * A * y) / (A * A - x * x - y * y))
              + (2 * x * y) / (4 * A * A * y * y + Math.Pow((A * A - x * x - y * y), 2))
                * (Pi * (A * A - x * x - y * y) + 4 * A * y));
        }

        public double DpsiDy(double x, double y, double t)
        {
            if (t % Period <= Period / 2.0)
            {
                return this.DpsiADy(x, y);
            }
            else
            {
                return this.DpsiBDy(x, y);
            }
        }

        public double DpsiDx(double x, double y, double t)
        {
            if (t % Period <= Period / 2.0)
            {
                return this.DpsiADx(x, y);
            }
            else
            {
                return this.DpsiBDx(x, y);
            }
        }

        public double PsiB(double x, double y)
        {
            return (-2 * U) / (Pi * Pi - 4) * ((Pi * A * y + A * A - x * x - y * y) / (A) * Math.Atan((2 * A * y) / (A * A - x * x - y * y))
                     - 0.5 * Pi * Pi * y);
        }

        public double DpsiBDy(double x, double y)
        {
            return (-2 * U) / (Pi * Pi - 4) * ((Pi * A - 2 * y) / (A) * Math.Atan((2 * A * y) / (A * A - x * x - y * y))
               + (2 * (A * A - x * x - y * y) + 4 * y * y) / (4 * A * A * y * y + Math.Pow((A * A - x * x - y * y), 2))
                * (Pi * A * y + A * A - x * x - y * y) - Pi * Pi * 0.5);
        }

        public double DpsiBDx(double x, double y)
        {
            return (-2 * U) / (Pi * Pi - 4) * ((-2 * x) / (A) * Math.Atan((2 * A * y) / (A * A - x * x - y * y))
                 + (4 * x * y) / (4 * A * A * y * y + Math.Pow((A * A - x * x - y * y), 2))
                * (Pi * A * y + A * A - x * x - y * y));
        }

        public double DuDx(double x, double y, double t)
        {
            return (DpsiDy(x + 0.0001, y, t) - DpsiDy(x, y, t)) / 0.0001;
        }
        public double DuDy(double x, double y, double t)
        {
            return (DpsiDy(x, y + 0.0001, t) - DpsiDy(x, y, t)) / 0.0001;
        }
        public double DvDx(double x, double y, double t)
        {
            return (DpsiDx(x + 0.0001, y, t) - DpsiDx(x, y, t)) / -0.0001;
        }
        public double DvDy(double x, double y, double t)
        {
            return (DpsiDx(x, y + 0.0001, t) - DpsiDx(x, y, t)) / -0.0001;
        }
    }
}