using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VitalLabels.Desktop.Models
{
    public class ExportBulk
    {
        public string Description { get; set; }
        public string BatchNumber { get; set; }
        public string Expiry { get; set; }
        public decimal Weight { get; set; }
    }
}
