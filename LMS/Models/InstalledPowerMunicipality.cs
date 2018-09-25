using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LMS.Models
{
    public class InstalledPowerMunicipality
    {
        public int ID { get; set; }

        public string Kommun { get; set; }

        public double BaseInstalledPower { get; set; }
        public int Inhabitants { get; set; }
    }
}