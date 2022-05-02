using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLATS_REF
{
    public class REF_Team
    {
        public int Team_ID { get; set; }
        public string Team_Name { get; set; }
        public string TargetLocation { get; set; }
        public string Description { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }
        public bool IsActive { get; set; }

    }
}
