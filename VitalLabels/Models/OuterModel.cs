using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VitalLabels.Desktop.Models
{
    public class OuterModel
    {
        public string StockCode { get; set; }
        public string Description { get; set; }
        public string BarcodeOuter { get; set; }
        public string Units { get; set; }
        public int? UnitsPerOuter { get; set; }
        public string PackingCode { get; set; }
        public string OuterCartonLabel { get; set; }
    }
}
