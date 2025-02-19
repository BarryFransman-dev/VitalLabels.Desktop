using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using VitalLabels.Desktop.Repository;

namespace VitalLabels.Desktop.Reports
{
    public partial class ACBShrinkLabelReport : DevExpress.XtraReports.UI.XtraReport
    {
        public ACBShrinkLabelReport()
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
