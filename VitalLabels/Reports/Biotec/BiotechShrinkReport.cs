using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using VitalLabels.Desktop.Repository;

namespace VitalLabels.Desktop.Reports
{
    public partial class BiotechShrinkReport : DevExpress.XtraReports.UI.XtraReport
    {
        public BiotechShrinkReport()
        {
            InitializeComponent();
        }

        private void BiotechReport_ParametersRequestSubmit(object sender, DevExpress.XtraReports.Parameters.ParametersRequestEventArgs e)
        {
            if (e.ParametersInformation[0].Parameter.Description == "Stock Code")
            {
                this.DataSource = new SqlRepository().GetBiotechSC(e.ParametersInformation[0].Parameter.Value.ToString()).ToList();
            }
            else
            {
                this.DataSource = new SqlRepository().GetBiotechJob(e.ParametersInformation[0].Parameter.Value.ToString()).ToList();
            }
        }
    }
}
