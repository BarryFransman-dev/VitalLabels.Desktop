using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using VitalLabels.Desktop.Repository;

namespace VitalLabels.Desktop.Reports
{
    public partial class InovaOuterCartonReport : DevExpress.XtraReports.UI.XtraReport
    {
        public InovaOuterCartonReport()
        {
            InitializeComponent();
        }

        //private void NautOuterCartonReport_ParametersRequestSubmit(object sender, DevExpress.XtraReports.Parameters.ParametersRequestEventArgs e)
        //{
        //    this.DataSource = new SqlRepository().GetOuterSC(e.ParametersInformation[0].Parameter.Value.ToString()).ToList();
        //}
        //private void InovatOuterCartonReport_ParametersRequestSubmit(object sender, DevExpress.XtraReports.Parameters.ParametersRequestEventArgs e)
        //{
        //}

        private void InovaOuterCartonReport_ParametersRequestSubmit(object sender, DevExpress.XtraReports.Parameters.ParametersRequestEventArgs e)
        {
            this.DataSource = new SqlRepository().GetOuterSC(e.ParametersInformation[0].Parameter.Value.ToString()).ToList();
        }
    }
}
