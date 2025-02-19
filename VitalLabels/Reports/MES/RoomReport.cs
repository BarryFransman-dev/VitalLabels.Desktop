using DevExpress.XtraReports.Parameters;
using System.Collections.Generic;
using System.Linq;
using VitalLabels.Desktop.Models;
using VitalLabels.Desktop.Repository;

namespace VitalLabels.Desktop.Reports
{
    public partial class RoomReport : DevExpress.XtraReports.UI.XtraReport
    {
        public RoomReport()
        {
            InitializeComponent();
        }

        private void RoomReport_ParametersRequestSubmit(object sender, ParametersRequestEventArgs e)
        {
            var selectedValue = e.ParametersInformation[0].Parameter.ValueSourceSettings as DynamicListLookUpSettings;
            var dataSource = selectedValue.DataSource as List<RoomModel>;
            this.DataSource = dataSource.Where(x => x.strRoomID == e.ParametersInformation[0].Parameter.Value.ToString());
        }
    }
}
