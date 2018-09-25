using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LMS.Models
{
    public class InstalledPowerOrganisation
    {
        public int ID { get; set; }

        public string Organisation { get; set; }
        public double BaseInstalledPower { get; set; }
    }
}