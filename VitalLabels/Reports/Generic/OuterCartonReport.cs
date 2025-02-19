using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using VitalLabels.Desktop.Repository;

namespace VitalLabels.Desktop.Reports
{
    public partial class OuterCartonReport : DevExpress.XtraReports.UI.XtraReport
    {
        public OuterCartonReport()
        {
            InitializeComponent();
        }

        private void OuterCartonReport_ParametersRequestSubmit(object sender, DevExpress.XtraReports.Parameters.ParametersRequestEventArgs e)
        {
            this.DataSource = new SqlRepository().GetACBSC(e.ParametersInformation[0].Parameter.Value.ToString()).ToList();
        }
    }
}
