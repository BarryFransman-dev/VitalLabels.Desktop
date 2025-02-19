using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using VitalLabels.Desktop.Models;
using VitalLabels.Desktop.Repository;

namespace VitalLabels.Desktop.Reports
{
    public partial class MESUserReport : DevExpress.XtraReports.UI.XtraReport
    {
        public MESUserReport()
        {
            InitializeComponent();
        }

        private void MESUserReport_ParametersRequestSubmit(object sender, DevExpress.XtraReports.Parameters.ParametersRequestEventArgs e)
        {
            var ds = new SqlRepository().GetUserCode(e.ParametersInformation[0].Parameter.Value.ToString()).ToList();
            if (ds.Count > 0 && ds.FirstOrDefault().Status == "LockedOut")
            {
                ds.FirstOrDefault().Password = null;
                ds.FirstOrDefault().DisplayCode = "USER LOCKED OUT";
            }
            this.DataSource = ds;
        }
    }
}
