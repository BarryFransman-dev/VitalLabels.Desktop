using System.Collections.Generic;
using System.Linq;
using VitalLabels.Desktop.Models;
using VitalLabels.Desktop.Repository;

namespace VitalLabels.Desktop.Reports
{
    public partial class PackingOuterReport : DevExpress.XtraReports.UI.XtraReport
    {
        public PackingOuterReport()
        {
            InitializeComponent();
        }

        private void PackingOuterReport_ParametersRequestSubmit(object sender, DevExpress.XtraReports.Parameters.ParametersRequestEventArgs e)
        {
            var ds = new SqlRepository().GetPackingOuter(e.ParametersInformation[0].Parameter.Value.ToString()).ToList() as List<PackingOuter>;
            if ((int?)e.ParametersInformation[1].Parameter.Value > 0)
            {
                ds.FirstOrDefault().Quantity = (int?)e.ParametersInformation[1].Parameter.Value;
            } 
            this.DataSource = ds;
        }
    }
}
