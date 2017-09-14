using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diploma
{
    public static class RungeKutClass
    {
        private static void ChangeSide(double t, double[] yp, CustomPoint y, Derives derives)
        {
            yp[0] = derives.DpsiDy(y.Coordinates[0], y.Coordinates[1], t);
            yp[1] = -derives.DpsiDx(y.Coordinates[0], y.Coordinates[1], t);
        }

        public static void Runge_Kut(int eNumber, double t, double tend, double dt, CustomPoint coordinate, Derives derives)
        {
            double[] tma = new double[eNumber], tmb = new double[eNumber], tmc = new double[eNumber], tmd = new double[eNumber], tme = new double[eNumber], tmf = new double[eNumber], yp = new double[eNumber];
            double dx = 0.1 * dt, tt = 0;
            int nt = (int)Math.Round((tend - t) / dx);
            nt = (nt < 1) ? 1 : nt;
            for (int it = 0; it < nt; it++)
            {
                for (int i = 0; i < eNumber; i++)
                {
                    tmf[i] = coordinate.Coordinates[i];
                }
                ChangeSide(t, yp, coordinate, derives);
                tt = t + 0.2222222222222222 * dx;

                for (int i = 0; i < eNumber; i++)
                {
                    tma[i] = yp[i] * dx;
                    coordinate.Coordinates[i] = tmf[i] + 0.22222222222222222 * tma[i];
                }
                ChangeSide(tt, yp, coordinate, derives);
                tt = t + 0.3333333333333333 * dx;

                for (int i = 0; i < eNumber; i++)
                {
                    tmb[i] = yp[i] * dx;
                    coordinate.Coordinates[i] = tmf[i] + 0.08333333333333333 * tma[i] + 0.25 * tmb[i];
                }
                ChangeSide(tt, yp, coordinate, derives);
                tt = t + 0.75 * dx;
                for (int i = 0; i < eNumber; i++)
                {
                    tmc[i] = yp[i] * dx;
                    coordinate.Coordinates[i] = tmf[i] + 0.5390625 * tma[i] - 1.8984375 * tmb[i] + 2.109375 * tmc[i];
                }
                ChangeSide(tt, yp, coordinate, derives);
                tt = t + dx;
                for (int i = 0; i < eNumber; i++)
                {
                    tmd[i] = yp[i] * dx;
                    coordinate.Coordinates[i] = tmf[i] - 1.4166666666666667 * tma[i] + 6.75 * tmb[i] - 5.4 * tmc[i] + 1.0666666666666667 * tmd[i];
                }
                ChangeSide(tt, yp, coordinate, derives);
                for (int i = 0; i < eNumber; i++)
                {
                    coordinate.Coordinates[i] = tmf[i] + 0.1111111111111111 * tma[i] + 0.45 * tmc[i] + 0.3555555555555556 * tmd[i] + 0.08333333333333333 * yp[i] * dx;
                }
            }
            ChangeSide(tt, yp, coordinate, derives);
        }
    }
}
