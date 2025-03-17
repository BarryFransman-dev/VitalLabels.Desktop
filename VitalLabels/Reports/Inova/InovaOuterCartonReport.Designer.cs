
namespace VitalLabels.Desktop.Reports
{
    partial class InovaOuterCartonReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraPrinting.BarCode.Code128Generator code128Generator1 = new DevExpress.XtraPrinting.BarCode.Code128Generator();
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery1 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InovaOuterCartonReport));
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.label3 = new DevExpress.XtraReports.UI.XRLabel();
            this.label11 = new DevExpress.XtraReports.UI.XRLabel();
            this.label1 = new DevExpress.XtraReports.UI.XRLabel();
            this.barCode1 = new DevExpress.XtraReports.UI.XRBarCode();
            this.label10 = new DevExpress.XtraReports.UI.XRLabel();
            this.label9 = new DevExpress.XtraReports.UI.XRLabel();
            this.label8 = new DevExpress.XtraReports.UI.XRLabel();
            this.label7 = new DevExpress.XtraReports.UI.XRLabel();
            this.label5 = new DevExpress.XtraReports.UI.XRLabel();
            this.label4 = new DevExpress.XtraReports.UI.XRLabel();
            this.label2 = new DevExpress.XtraReports.UI.XRLabel();
            this.label12 = new DevExpress.XtraReports.UI.XRLabel();
            this.label6 = new DevExpress.XtraReports.UI.XRLabel();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.paramStockCode = new DevExpress.XtraReports.Parameters.Parameter();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // TopMargin
            // 
            this.TopMargin.Dpi = 254F;
            this.TopMargin.HeightF = 0F;
            this.TopMargin.Name = "TopMargin";
            // 
            // BottomMargin
            // 
            this.BottomMargin.Dpi = 254F;
            this.BottomMargin.HeightF = 0F;
            this.BottomMargin.Name = "BottomMargin";
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.label3,
            this.label11,
            this.label1,
            this.barCode1,
            this.label10,
            this.label9,
            this.label8,
            this.label7,
            this.label5,
            this.label4,
            this.label2,
            this.label12,
            this.label6});
            this.Detail.Dpi = 254F;
            this.Detail.HeightF = 998F;
            this.Detail.HierarchyPrintOptions.Indent = 50.8F;
            this.Detail.Name = "Detail";
            // 
            // label3
            // 
            this.label3.Dpi = 254F;
            this.label3.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.label3.LocationFloat = new DevExpress.Utils.PointFloat(44.45F, 24.99999F);
            this.label3.Name = "label3";
            this.label3.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.label3.SizeF = new System.Drawing.SizeF(915.6059F, 90.17005F);
            this.label3.StylePriority.UseFont = false;
            this.label3.Text = "[Description]";
            // 
            // label11
            // 
            this.label11.Dpi = 254F;
            this.label11.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.LocationFloat = new DevExpress.Utils.PointFloat(60.32448F, 563.6682F);
            this.label11.Name = "label11";
            this.label11.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.label11.SizeF = new System.Drawing.SizeF(332F, 45.19092F);
            this.label11.StylePriority.UseFont = false;
            this.label11.Text = "Packaging Code:";
            // 
            // label1
            // 
            this.label1.Dpi = 254F;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.LocationFloat = new DevExpress.Utils.PointFloat(60.32448F, 608.8592F);
            this.label1.Name = "label1";
            this.label1.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.label1.SizeF = new System.Drawing.SizeF(185.209F, 45.1908F);
            this.label1.StylePriority.UseFont = false;
            this.label1.Text = "Address:";
            // 
            // barCode1
            // 
            this.barCode1.Alignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.barCode1.AutoModule = true;
            this.barCode1.Dpi = 254F;
            this.barCode1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barCode1.LocationFloat = new DevExpress.Utils.PointFloat(126.4703F, 126.3382F);
            this.barCode1.Module = 5.08F;
            this.barCode1.Name = "barCode1";
            this.barCode1.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254F);
            this.barCode1.SizeF = new System.Drawing.SizeF(749.2596F, 374.4357F);
            this.barCode1.StylePriority.UseFont = false;
            this.barCode1.StylePriority.UsePadding = false;
            this.barCode1.StylePriority.UseTextAlignment = false;
            code128Generator1.CharacterSet = DevExpress.XtraPrinting.BarCode.Code128Charset.CharsetB;
            this.barCode1.Symbology = code128Generator1;
            this.barCode1.Text = "[BarcodeOuter]";
            this.barCode1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter;
            this.barCode1.TextFormatString = "{0:}";
            // 
            // label10
            // 
            this.label10.Dpi = 254F;
            this.label10.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.LocationFloat = new DevExpress.Utils.PointFloat(392.3249F, 563.6682F);
            this.label10.Name = "label10";
            this.label10.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.label10.SizeF = new System.Drawing.SizeF(540.0847F, 45.19092F);
            this.label10.StylePriority.UseFont = false;
            this.label10.Text = "[OuterCartonLabel]";
            // 
            // label9
            // 
            this.label9.Dpi = 254F;
            this.label9.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.LocationFloat = new DevExpress.Utils.PointFloat(245.5338F, 608.8588F);
            this.label9.Name = "label9";
            this.label9.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.label9.SizeF = new System.Drawing.SizeF(686.8757F, 45.19092F);
            this.label9.StylePriority.UseFont = false;
            this.label9.Text = "United Pharmaceutical Distributors";
            // 
            // label8
            // 
            this.label8.Dpi = 254F;
            this.label8.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.LocationFloat = new DevExpress.Utils.PointFloat(245.5338F, 654.05F);
            this.label8.Name = "label8";
            this.label8.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.label8.SizeF = new System.Drawing.SizeF(686.876F, 45.1908F);
            this.label8.StylePriority.UseFont = false;
            this.label8.Text = "14 Tamar Avenue, Lea Glen";
            // 
            // label7
            // 
            this.label7.Dpi = 254F;
            this.label7.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.LocationFloat = new DevExpress.Utils.PointFloat(245.5338F, 699.2408F);
            this.label7.Name = "label7";
            this.label7.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.label7.SizeF = new System.Drawing.SizeF(686.8757F, 45.19073F);
            this.label7.StylePriority.UseFont = false;
            this.label7.Text = "Roodepoort";
            // 
            // label5
            // 
            this.label5.Dpi = 254F;
            this.label5.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.LocationFloat = new DevExpress.Utils.PointFloat(245.5338F, 789.6222F);
            this.label5.Name = "label5";
            this.label5.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.label5.SizeF = new System.Drawing.SizeF(686.876F, 45.1908F);
            this.label5.StylePriority.UseFont = false;
            this.label5.Text = "South Africa";
            // 
            // label4
            // 
            this.label4.Dpi = 254F;
            this.label4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.LocationFloat = new DevExpress.Utils.PointFloat(245.5338F, 834.813F);
            this.label4.Name = "label4";
            this.label4.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.label4.SizeF = new System.Drawing.SizeF(686.8757F, 45.1908F);
            this.label4.StylePriority.UseFont = false;
            this.label4.Text = "Phone: (021) 501 0740";
            this.label4.Visible = false;
            // 
            // label2
            // 
            this.label2.Dpi = 254F;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.LocationFloat = new DevExpress.Utils.PointFloat(245.5338F, 515.8314F);
            this.label2.Name = "label2";
            this.label2.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.label2.SizeF = new System.Drawing.SizeF(686.8757F, 47.83664F);
            this.label2.StylePriority.UseFont = false;
            this.label2.Text = "[UnitsPerOuter]";
            // 
            // label12
            // 
            this.label12.Dpi = 254F;
            this.label12.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.LocationFloat = new DevExpress.Utils.PointFloat(60.32448F, 515.8314F);
            this.label12.Name = "label12";
            this.label12.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.label12.SizeF = new System.Drawing.SizeF(185.209F, 47.83658F);
            this.label12.StylePriority.UseFont = false;
            this.label12.Text = "Quantity:";
            // 
            // label6
            // 
            this.label6.Dpi = 254F;
            this.label6.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.LocationFloat = new DevExpress.Utils.PointFloat(245.5338F, 744.4316F);
            this.label6.Name = "label6";
            this.label6.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.label6.SizeF = new System.Drawing.SizeF(686.8757F, 45.1908F);
            this.label6.StylePriority.UseFont = false;
            this.label6.Text = "Johannesburg, 1709";
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "CompA";
            this.sqlDataSource1.Name = "sqlDataSource1";
            customSqlQuery1.Name = "Query";
            customSqlQuery1.Sql = resources.GetString("customSqlQuery1.Sql");
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // paramStockCode
            // 
            this.paramStockCode.Description = "Stock Code";
            this.paramStockCode.Name = "paramStockCode";
            // 
            // InovaOuterCartonReport
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.BottomMargin,
            this.Detail});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.sqlDataSource1});
            this.Dpi = 254F;
            this.Font = new System.Drawing.Font("Arial", 9.75F);
            this.Margins = new System.Drawing.Printing.Margins(0, 0, 0, 0);
            this.PageHeight = 1005;
            this.PageWidth = 1000;
            this.PaperKind = System.Drawing.Printing.PaperKind.Custom;
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.paramStockCode});
            this.ReportUnit = DevExpress.XtraReports.UI.ReportUnit.TenthsOfAMillimeter;
            this.ShowPrintMarginsWarning = false;
            this.SnapGridSize = 25F;
            this.Version = "21.1";
            this.ParametersRequestSubmit += new System.EventHandler<DevExpress.XtraReports.Parameters.ParametersRequestEventArgs>(this.InovaOuterCartonReport_ParametersRequestSubmit);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraReports.UI.XRLabel label3;
        private DevExpress.XtraReports.UI.XRLabel label11;
        private DevExpress.XtraReports.UI.XRLabel label1;
        private DevExpress.XtraReports.UI.XRBarCode barCode1;
        private DevExpress.XtraReports.UI.XRLabel label9;
        private DevExpress.XtraReports.UI.XRLabel label8;
        private DevExpress.XtraReports.UI.XRLabel label7;
        private DevExpress.XtraReports.UI.XRLabel label5;
        private DevExpress.XtraReports.UI.XRLabel label4;
        private DevExpress.XtraReports.UI.XRLabel label2;
        private DevExpress.XtraReports.UI.XRLabel label12;
        private DevExpress.XtraReports.UI.XRLabel label6;
        private DevExpress.XtraReports.Parameters.Parameter paramStockCode;
        private DevExpress.XtraReports.UI.XRLabel label10;
        //private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource2;
    }
}
