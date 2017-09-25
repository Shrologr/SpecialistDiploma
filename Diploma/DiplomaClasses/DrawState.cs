using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;

namespace WpfDiploma
{
    [Serializable]
    public class DrawState
    {
        public Derives DeriveData;
        public double Dt;
        public List<CustomPoint> Points;
        public DrawState()
        {

        }
        public DrawState(Derives derives, int timeIndex, double dt, List<CustomPoint> points)
        {
            DeriveData = derives;
            Dt = dt;
            Points = points;
        }
    }
}
