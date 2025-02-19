using System.Linq;
using VitalLabels.Desktop.Repository;

namespace VitalLabels.Desktop.Reports
{
    public partial class ShrinkLabelReport : DevExpress.XtraReports.UI.XtraReport
    {
        public ShrinkLabelReport()
        {
            InitializeComponent();
        }

        private void ShrinkLabelReport_ParametersRequestSubmit(object sender, DevExpress.XtraReports.Parameters.ParametersRequestEventArgs e)
        {
            if (e.ParametersInformation[0].Parameter.Description == "Stock Code")
            {
                this.DataSource = new SqlRepository().GetShrinkSKU(e.ParametersInformation[0].Parameter.Value.ToString()).ToList();
            }
            else
            {
                this.DataSource = new SqlRepository().GetShrinkJob(e.ParametersInformation[0].Parameter.Value.ToString()).ToList();
            }
        }
    }
}
