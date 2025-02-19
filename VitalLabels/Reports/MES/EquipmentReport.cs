using DevExpress.XtraReports.Parameters;
using System.Collections.Generic;
using System.Linq;
using VitalLabels.Desktop.Models;
using VitalLabels.Desktop.Repository;

namespace VitalLabels.Desktop.Reports
{
    public partial class EquipmentReport : DevExpress.XtraReports.UI.XtraReport
    {
        public EquipmentReport()
        {
            InitializeComponent();
        }

        private void EquipmentReport_ParametersRequestSubmit(object sender, ParametersRequestEventArgs e)
        {
            var selectedValue = e.ParametersInformation[0].Parameter.ValueSourceSettings as DynamicListLookUpSettings;
            var dataSource = selectedValue.DataSource as List<EquipmentModel>;
            this.DataSource = dataSource.Where(x => x.intBarcodeID == e.ParametersInformation[0].Parameter.Value.ToString());
        }
    }
}
