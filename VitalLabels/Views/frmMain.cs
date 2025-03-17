using DevExpress.DataAccess.Sql;
using DevExpress.XtraPrinting.Preview;
using DevExpress.XtraReports.Parameters;
using System.Collections.Generic;
using System.Windows.Forms;
using VitalLabels.Desktop.Properties;
using VitalLabels.Desktop.Reports;
using VitalLabels.Desktop.Repository;
using VitalLabels.Desktop.Views;

namespace VitalLabels
{
    public partial class frmMain : Form
    {
        private SqlRepository sqlRepository;

        public frmMain()
        {
            InitializeComponent();
            sqlRepository = new SqlRepository();
        }

        #region ACB
        private void bbiACBOuter_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            documentViewer1.DocumentSource = new ACBOuterCartonReport();
            Text = "Nautilus Labels - ACB Outer Carton Label";
            var dp = documentViewer1.GetDockPanel(PreviewDockPanelKind.Parameters);
            dp.Width = 300;
            documentViewer1.InitiateDocumentCreation();
        }

        private void bbiACBShrinkJob_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var report = new ACBShrinkLabelReport();
            report.Parameters[0].Description = "Job No.";
            documentViewer1.DocumentSource = report;
            Text = "Nautilus Labels - ACB Shrink Label";
            var dp = documentViewer1.GetDockPanel(PreviewDockPanelKind.Parameters);
            dp.Width = 300;
            documentViewer1.InitiateDocumentCreation();
        }

        private void bbiACBShrinkSKU_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var report = new ACBShrinkLabelReport();
            report.Parameters[0].Description = "Stock Code";
            documentViewer1.DocumentSource = report;
            Text = "Nautilus Labels - ACB Shrink Label";
            var dp = documentViewer1.GetDockPanel(PreviewDockPanelKind.Parameters);
            dp.Width = 300;
            documentViewer1.InitiateDocumentCreation();
        }
        #endregion

        #region Biotech
        private void bbiBiotech_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            documentViewer1.DocumentSource = new BiotechReport();
            Text = "Nautilus Labels - Biotech Shrink Label";
            var dp = documentViewer1.GetDockPanel(PreviewDockPanelKind.Parameters);
            dp.Width = 300;
            documentViewer1.InitiateDocumentCreation();
        }

        private void bbiBiotechOuter_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            documentViewer1.DocumentSource = new BiotechOuterReport();
            Text = "Nautilus Labels - Biotech Outer Label";
            var dp = documentViewer1.GetDockPanel(PreviewDockPanelKind.Parameters);
            dp.Width = 300;
            documentViewer1.InitiateDocumentCreation();
        }

        #endregion

        #region Generic
        private void bbiGenShrinkJob_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var report = new ShrinkLabelReport();
            report.Parameters[0].Description = "Job No.";
            documentViewer1.DocumentSource = report;
            Text = "Nautilus Labels - Generic Shrink Label";
            var dp = documentViewer1.GetDockPanel(PreviewDockPanelKind.Parameters);
            dp.Width = 300;
            documentViewer1.InitiateDocumentCreation();
        }

        private void bbiGenShrinkSKU_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var report = new ShrinkLabelReport();
            report.Parameters[0].Description = "Stock Code";
            documentViewer1.DocumentSource = report;
            Text = "Nautilus Labels - Generic Shrink Label";
            var dp = documentViewer1.GetDockPanel(PreviewDockPanelKind.Parameters);
            dp.Width = 300;
            documentViewer1.InitiateDocumentCreation();
        }

        private void bbiGenOuter_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            documentViewer1.DocumentSource = new OuterCartonReport();
            Text = "Nautilus Labels - Generic Outer Label";
            var dp = documentViewer1.GetDockPanel(PreviewDockPanelKind.Parameters);
            dp.Width = 300;
            documentViewer1.InitiateDocumentCreation();
        }
        #endregion

        #region MES
        private void bbiUserBarcode_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Text != "Nautilus Labels - MES User Label")
            {
                var pwf = new PasswordInputForm();
                pwf.ShowDialog();
                if (pwf.passwordTextBox.Text != Settings.Default.MESLabelPW)
                {
                    MessageBox.Show("Incorrect Password");
                    return;
                }
            }

            documentViewer1.DocumentSource = new MESUserReport();
            Text = "Nautilus Labels - MES User Label";
            var dp = documentViewer1.GetDockPanel(PreviewDockPanelKind.Parameters);
            dp.Width = 300;
            documentViewer1.InitiateDocumentCreation();
        }

        private void bbiPaking_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var qtyParameter = new Parameter
            {
                Name = "Quantity",
                Description = "Quantity:",
                Type = typeof(int),
            };

            var report = new PackingOuterReport();
            report.Parameters.Add(qtyParameter);
            report.Parameters[0].Description = "Batch No.:";
            documentViewer1.DocumentSource = report;
            Text = "Nautilus Labels - Packing Outer Label";
            var dp = documentViewer1.GetDockPanel(PreviewDockPanelKind.Parameters);
            dp.Width = 300;
            documentViewer1.InitiateDocumentCreation();
        }

        private void bbiBulkLabel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var weightParameter = new Parameter
            {
                Name = "Weight",
                Description = "Weight:",
                Type = typeof(decimal),
            };

            var report = new ExportBulkReport();
            report.Parameters.Add(weightParameter);
            report.Parameters[0].Description = "Batch No.:";
            documentViewer1.DocumentSource = report;
            Text = "Nautilus Labels - Export Bulk Label";
            var dp = documentViewer1.GetDockPanel(PreviewDockPanelKind.Parameters);
            dp.Width = 300;
            documentViewer1.InitiateDocumentCreation();
        }

        private void bbiRoom_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var roomParameter = new Parameter
            {
                Name = "Room",
                Description = "Select Room:",
                Type = typeof(string),
                MultiValue = false
            };

            // Define the lookup settings for the parameter
            var lookupSettings = new DynamicListLookUpSettings
            {
                DataSource = sqlRepository.GetRoom(),
                //DataMember = "EquipmentQuery",
                DisplayMember = "strRoomDescription", // Display field in the dropdown
                ValueMember = "strRoomID" // Value field to pass to the report
            };
            roomParameter.LookUpSettings = lookupSettings;

            var report = new RoomReport();
            report.Parameters.Add(roomParameter);
            documentViewer1.DocumentSource = report;
            Text = "Nautilus Labels - Room Label";
            var dp = documentViewer1.GetDockPanel(PreviewDockPanelKind.Parameters);
            dp.Width = 300;
            documentViewer1.InitiateDocumentCreation();
        }

        private void bbiEquipment_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //var sqlDataSource = new SqlDataSource("data source=indra01;initial catalog=VitalProduction;persist security info=True;user id=CoA_ODBC;password=coa_odbc;MultipleActiveResultSets=True;App=EntityFramework");

            //// Define a query to fetch the lookup values from the database
            //var customSqlQuery = new CustomSqlQuery();
            //customSqlQuery.Name = "EquipmentQuery";
            //customSqlQuery.Sql = "SELECT intBarcodeID,strEquipmentName,strEquipmentDesc " +
            //                        "FROM[VitalProduction].[dbo].[tblEquipmentLookup] " +
            //                        "order by strEquipmentName"; // Update this with your table and columns
            //sqlDataSource.Queries.Add(customSqlQuery);
            //sqlDataSource.Fill();

            // Set up the parameter
            var equipmentParameter = new Parameter
            {
                Name = "Equipment",
                Description = "Select Equipment:",
                Type = typeof(string),
                MultiValue = false
            };

            // Define the lookup settings for the parameter
            var lookupSettings = new DynamicListLookUpSettings
            {
                DataSource = sqlRepository.GetEquipment(),
                //DataMember = "EquipmentQuery",
                DisplayMember = "strEquipmentName", // Display field in the dropdown
                ValueMember = "intBarcodeID" // Value field to pass to the report
            };
            equipmentParameter.LookUpSettings = lookupSettings;

            var report = new EquipmentReport();
            report.Parameters.Add(equipmentParameter);
            documentViewer1.DocumentSource = report;
            Text = "Nautilus Labels - Equipment Label";
            var dp = documentViewer1.GetDockPanel(PreviewDockPanelKind.Parameters);
            dp.Width = 300;
            documentViewer1.InitiateDocumentCreation();
        }

        private void bbiWater_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //var ds = new SysproContext().LotDetail;
            documentViewer1.DocumentSource = new WaterLabelReport().DataSource;
            Text = "Nautilus Labels - Water Label";
            var dp = documentViewer1.GetDockPanel(PreviewDockPanelKind.Parameters);
            dp.Width = 300;
            documentViewer1.InitiateDocumentCreation();
        }

        #endregion

        #region Vital
        private void bbiOuterLabel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            documentViewer1.DocumentSource = new NautOuterCartonReport(); 
             Text = "Nautilus Labels - Vital Outer Carton Label";
            var dp = documentViewer1.GetDockPanel(PreviewDockPanelKind.Parameters);
            dp.Width = 300;
            documentViewer1.InitiateDocumentCreation();
        }
        #endregion

        private void biInovaOuter_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            documentViewer1.DocumentSource = new InovaOuterCartonReport();
            Text = "Inova Labels - Inova Outer Carton Label";
            var dp = documentViewer1.GetDockPanel(PreviewDockPanelKind.Parameters);
            dp.Width = 300;
            documentViewer1.InitiateDocumentCreation();
        }
    }
}
