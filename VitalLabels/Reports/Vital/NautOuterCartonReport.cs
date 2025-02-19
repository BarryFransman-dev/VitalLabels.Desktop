using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using VitalLabels.Desktop.Repository;

namespace VitalLabels.Desktop.Reports
{
    public partial class NautOuterCartonReport : DevExpress.XtraReports.UI.XtraReport
    {
        public NautOuterCartonReport()
        {
            InitializeComponent();
        }

        private void NautOuterCartonReport_ParametersRequestSubmit(object sender, DevExpress.XtraReports.Parameters.ParametersRequestEventArgs e)
        {
            this.DataSource = new SqlRepository().GetOuterSC(e.ParametersInformation[0].Parameter.Value.ToString()).ToList();
        }
    }
}
