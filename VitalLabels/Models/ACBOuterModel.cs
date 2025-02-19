using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VitalLabels.Desktop.Models
{
    public class ACBOuterModel
    {
        public string StockCode { get; set; }
        public string Description { get; set; }
        public string CustStockCode { get; set; }
        public string AlternateKey1 { get; set; }
        public string BarcodeOuter { get; set; }
        public int? Quantity { get; set; }
        public decimal? UnitsPerOuter { get; set; }
        public string OuterCartonLabel { get; set; }
    }
}
