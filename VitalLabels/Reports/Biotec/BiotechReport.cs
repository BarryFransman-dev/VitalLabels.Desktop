using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using VitalLabels.Desktop.Repository;

namespace VitalLabels.Desktop.Reports
{
    public partial class BiotechReport : DevExpress.XtraReports.UI.XtraReport
    {
        public BiotechReport()
        {
            InitializeComponent();
        }

        private void BiotechReport_ParametersRequestSubmit(object sender, DevExpress.XtraReports.Parameters.ParametersRequestEventArgs e)
        {
            this.DataSource = new SqlRepository().GetBiotechSC(e.ParametersInformation[0].Parameter.Value.ToString()).ToList();
        }
    }
}
