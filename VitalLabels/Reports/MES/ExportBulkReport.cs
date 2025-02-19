using System.Collections.Generic;
using System.Linq;
using VitalLabels.Desktop.Models;
using VitalLabels.Desktop.Repository;

namespace VitalLabels.Desktop.Reports
{
    public partial class ExportBulkReport : DevExpress.XtraReports.UI.XtraReport
    {
        public ExportBulkReport()
        {
            InitializeComponent();
        }

        private void ExportBulkReport_ParametersRequestSubmit(object sender, DevExpress.XtraReports.Parameters.ParametersRequestEventArgs e)
        {
            var ds = new SqlRepository().GetExportBulk(e.ParametersInformation[0].Parameter.Value.ToString()).ToList() as List<ExportBulk>;
            if ((decimal)e.ParametersInformation[1].Parameter.Value > 0)
            {
                ds.FirstOrDefault().Weight = (decimal)e.ParametersInformation[1].Parameter.Value;
            }
            this.DataSource = ds;
        }
    }
}
