using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WpfDiploma
{
    [DataContract]
    public class PointState
    {
        [DataMember]
        public double[] Coordinates { get; set; }
    }
}
