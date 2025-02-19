using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VitalLabels.Desktop.Reports
{
    public class BiotechOuterModel
    {
        public string Description { get; set; }
        public string StockCode { get; set; }
        public string OuterCartonLabel { get; set; }
        public int? UnitsPerOuter { get; set; }
        public string BarcodeOuter { get; set; }
    }
}
