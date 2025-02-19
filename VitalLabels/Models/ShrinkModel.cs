using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VitalLabels.Desktop.Models
{
    public class ShrinkModel
    {
        public string Job { get; set; }
        public string Description { get; set; }
        public string StockCode { get; set; }
        public string JobDescription { get; set; }
        public string BarcodeShrinks { get; set; }
        public string PackingCode { get; set; }
        public int? ShrinkSize { get; set; }
        public string CustStockCode { get; set; }
    }
}
