using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VitalLabels.Desktop.Models;
using VitalLabels.Desktop.Reports;

namespace VitalLabels.Desktop.Repository
{
    public class SqlRepository
    {
        public IEnumerable<ACBOuterModel> GetACBSC(string passStockCode)
        {
            var retSql = new SysproContext().Database.SqlQuery<ACBOuterModel>("select i.StockCode,x.CustStockCode,x.Description, p.UnitsPerOuter, p.OuterCartonLabel,p.BarcodeOuter " +
                                                                              "From InvMaster i " +
                                                                              "Join [InvMaster+] p on p.StockCode = i.StockCode " +
                                                                              "Left Outer Join(Select * from ArCustStkXref where Customer = '71C03A') x on x.StockCode = i.StockCode " +
                                                                              "where i.StockCode = '" + passStockCode + "'");
            return retSql;
        }


        public IEnumerable<ACBOuterModel> GetGenSC(string passStockCode)
        {
            var retSql = new SysproContext().Database.SqlQuery<ACBOuterModel>("select i.StockCode,'' CustStockCode,i.Description, p.UnitsPerOuter, p.OuterCartonLabel,p.BarcodeOuter " +
                                                                              "From InvMaster i " +
                                                                              "Join [InvMaster+] p on p.StockCode = i.StockCode " +
                                                                              //"Left Outer Join(Select * from ArCustStkXref where Customer = '71C03A') x on x.StockCode = i.StockCode " +
                                                                              "where i.StockCode = '" + passStockCode + "'");
            return retSql;
        }

        public IEnumerable<OuterModel> GetOuterSC(string passStockCode)
        {
            var retSql = new SysproContext().Database.SqlQuery<OuterModel>("select i.StockCode,i.Description,p.BarcodeOuter " +
                                                                            ",convert(int,p.UnitsPerOuter) UnitsPerOuter " +
                                                                            ",p.BarcodeCode PackingCode, p.OuterCartonLabel " +
                                                                            "From InvMaster i " +
                                                                            "Join[InvMaster+] p on p.StockCode = i.StockCode " +
                                                                            "where i.StockCode = '" + passStockCode + "'");
            return retSql;
        }

        public IEnumerable<ShrinkModel> GetShrinkJob(string passJob)
        {
            var retSql = new SysproContext().Database.SqlQuery<ShrinkModel>("select replace(ltrim(replace(w.Job,'0',' ')),' ','0') Job, i.Description, w.StockCode, x.CustStockCode, " +
                                                                            "w.JobDescription, p.BarcodeShrinks, p.BarcodeCode PackingCode, convert(int,p.UnitsPerShrink) " +
                                                                            "ShrinkSize from WipMaster w join[InvMaster+] p on w.StockCode = p.StockCode " +
                                                                            "join InvMaster i on w.StockCode = i.StockCode " +
                                                                            "Left Outer Join(Select * from ArCustStkXref where Customer = '71C03A') x on x.StockCode = i.StockCode " +
                                                                            "where replace(ltrim(replace(w.Job, '0', ' ')), ' ', '0') = '" + passJob + "'");
            return retSql;
        }

        public IEnumerable<ShrinkModel> GetShrinkSKU(string passSKU)
        {
            var retSql = new SysproContext().Database.SqlQuery<ShrinkModel>("select i.StockCode,i.Description, x.CustStockCode, " +
                                                                            "p.BarcodeShrinks, p.BarcodeCode PackingCode, convert(int,p.UnitsPerShrink) ShrinkSize " +
                                                                            "from [InvMaster+] p join InvMaster i on p.StockCode = i.StockCode " +
                                                                            "Left Outer Join(Select * from ArCustStkXref where Customer = '71C03A') x on x.StockCode = i.StockCode " +
                                                                            "where i.StockCode = '" + passSKU + "'");
            //var x = retSql.ToList();
            return retSql.ToList();
        }





        public IEnumerable<ShrinkModel> GetShrinkGenJob(string passJob)
        {
            var retSql = new SysproContext().Database.SqlQuery<ShrinkModel>("select replace(ltrim(replace(w.Job,'0',' ')),' ','0') Job, i.Description, w.StockCode, '' CustStockCode, " +
                                                                            "w.JobDescription, p.BarcodeShrinks, p.BarcodeCode PackingCode, convert(int,p.UnitsPerShrink) " +
                                                                            "ShrinkSize from WipMaster w join[InvMaster+] p on w.StockCode = p.StockCode " +
                                                                            "join InvMaster i on w.StockCode = i.StockCode " +
                                                                            //"Left Outer Join(Select * from ArCustStkXref where Customer = '71C03A') x on x.StockCode = i.StockCode " +
                                                                            "where replace(ltrim(replace(w.Job, '0', ' ')), ' ', '0') = '" + passJob + "'");
            return retSql;
        }

        public IEnumerable<ShrinkModel> GetShrinkGenSKU(string passSKU)
        {
            var retSql = new SysproContext().Database.SqlQuery<ShrinkModel>("select i.StockCode,i.Description, '' CustStockCode, " +
                                                                            "p.BarcodeShrinks, p.BarcodeCode PackingCode, convert(int,p.UnitsPerShrink) ShrinkSize " +
                                                                            "from [InvMaster+] p join InvMaster i on p.StockCode = i.StockCode " +
                                                                            //"Left Outer Join(Select * from ArCustStkXref where Customer = '71C03A') x on x.StockCode = i.StockCode " +
                                                                            "where i.StockCode = '" + passSKU + "'");
            //var x = retSql.ToList();
            return retSql.ToList();
        }




        public IEnumerable<BiotechModel> GetBiotechSC(string passSKU)
        {
            var retSql = new SysproContext().Database.SqlQuery<BiotechModel>("select i.Description,i.StockCode,p.BarcodeShrinks, p.BarcodeCode PackingCode, " +
                                                                             "convert(int,p.UnitsPerShrink) ShrinkSize " +
                                                                             "from [InvMaster+] p " +
                                                                             "join InvMaster i on i.StockCode = p.StockCode " +
                                                                             "where i.StockCode = '" + passSKU + "'");
            return retSql;
        }

        public IEnumerable<BiotechModel> GetBiotechJob(string passJob)
        {
            var retSql = new SysproContext().Database.SqlQuery<BiotechModel>("select replace(ltrim(replace(w.Job,'0',' ')),' ','0') Job, w.JobDescription, i.Description, " +
                                                                             "i.StockCode,p.BarcodeShrinks, p.BarcodeCode PackingCode, " +
                                                                             "convert(int,p.UnitsPerShrink) ShrinkSize " +
                                                                             "from WipMaster w " +
                                                                             "join [InvMaster+] p on w.StockCode = p.StockCode " +
                                                                             "join InvMaster i on i.StockCode = p.StockCode " +
                                                                             "where replace(ltrim(replace(w.Job, '0', ' ')), ' ', '0') = '" + passJob + "'");
            return retSql;
        }

        public IEnumerable<BiotechOuterModel> GetBiotechOuterSC(string passStockCode)
        {
            var retSql = new SysproContext().Database.SqlQuery<BiotechOuterModel>("select i.Description,i.StockCode,p.BarcodeOuter, p.OuterCartonLabel, " +
                                                                             "convert(int,p.UnitsPerOuter) UnitsPerOuter " +
                                                                             "from[InvMaster+] p " +
                                                                             "join InvMaster i on i.StockCode = p.StockCode " +
                                                                             "where i.StockCode = '" + passStockCode + "'");
            return retSql;
        }

        public IEnumerable<UserModel> GetUserCode(string passUser)
        {
            var retSql = new mesContext().Database.SqlQuery<UserModel>("SELECT dbo.aspnet_Users.UserName, dbo.aspnet_Profile.PropertyValuesString DisplayCode, " +
                                                                        "dbo.aspnet_Profile.Password, " +
	                                                                    "case when IsLockedOut = 0 then ' ' else 'LockedOut' end as Status " +
                                                                        "FROM dbo.aspnet_Users " +
                                                                        "INNER JOIN dbo.aspnet_Profile ON dbo.aspnet_Users.UserId = dbo.aspnet_Profile.UserId " +
                                                                        "INNER JOIN dbo.aspnet_Membership on dbo.aspnet_Profile.UserId = dbo.aspnet_Membership.UserId " +
                                                                        "where dbo.aspnet_Users.UserName = '" + passUser + "'");
            return retSql;
        }


        public IEnumerable<ExportBulk> GetExportBulk(string passBatch)
        {
            var retSql = new mesContext().Database.SqlQuery<ExportBulk>("select top(1) '" + passBatch + "' BatchNumber, strJob, p.strBulkCode StockCode, " +
                                                                        "p.strProductName Description, CONVERT(decimal(18, 2), ip.UnitsPerOuter) Weight, " +
                                                                        "w.Job LotJob, lot.ExpiryDate Expiry " +
                                                                        "from tblBatch b " +
                                                                        "join tblProduct p on b.intProductID = p.intProductID " +
                                                                        "left outer join vhfcptfin01a.EncoreCompanyA.dbo.[InvMaster+] ip on p.strBulkCode = ip.StockCode collate Latin1_General_BIN " +
                                                                        "join vhfcptfin01a.EncoreCompanyA.dbo.WipMaster w on w.Job = strJob  collate Latin1_General_BIN " +
                                                                        "join (select distinct Lot, LEFT(Convert(date, Min(ExpiryDate)), LEN(Convert(date, Min(ExpiryDate))) - 3) ExpiryDate  " +
                                                                        "From vhfcptfin01a.EncoreCompanyA.dbo.LotDetail where QtyOnHand > 0 group by Lot) lot on lot.Lot = w.Job " +
                                                                        "where strBatchNo = '" + passBatch.Substring(0,13) + "'");
            return retSql.ToList();
        }

        public IEnumerable<PackingOuter> GetPackingOuter(string passBatch)
        {
            var retSql = new mesContext().Database.SqlQuery<PackingOuter>("select top(1) strBatchNo BatchNumber, strJob, substring(strBatchNo, 1, 13) KeyField, p.strBulkCode StockCode, " +
                                                                            "p.strProductName Description, CONVERT(int, ip.UnitsPerOuter) Quantity, " +
                                                                            "w.Job LotJob, lot.ExpiryDate Expiry " +
                                                                            "from tblBatch b " +
                                                                            "join tblProduct p on b.intProductID = p.intProductID " +
                                                                            "left outer join vhfcptfin01a.EncoreCompanyA.dbo.[InvMaster+] ip on p.strBulkCode = ip.StockCode collate Latin1_General_BIN " +
                                                                            "join vhfcptfin01a.EncoreCompanyA.dbo.WipMaster w on w.JobDescription = substring(strBatchNo, 1, 13) collate Latin1_General_BIN " +
                                                                            "join (select distinct Lot, LEFT(Convert(date, Min(ExpiryDate)), LEN(Convert(date, Min(ExpiryDate))) - 3) ExpiryDate " +
                                                                            "From vhfcptfin01a.EncoreCompanyA.dbo.LotDetail where QtyOnHand > 0 group by Lot) lot on lot.Lot = w.Job " +
                                                                            "where strBatchNo = '" + passBatch + "'");
            return retSql.ToList();
        }

        public IEnumerable<EquipmentModel> GetEquipment()
        {
            var retSql = new mesContext().Database.SqlQuery<EquipmentModel>("SELECT intBarcodeID,strEquipmentName,strEquipmentDesc " +
                                                                            "FROM[VitalProduction].[dbo].[tblEquipmentLookup] " +
                                                                            "order by strEquipmentName");
            return retSql.ToList();
        }

        public IEnumerable<RoomModel> GetRoom()
        {
            var retSql = new mesContext().Database.SqlQuery<RoomModel>("SELECT r.strRoomID,r.strRoomDescription,a.strAreaName,r.dtmAUDDateTime " +
                                                                            "FROM [VitalProduction].[dbo].[tblRoom] r " +
                                                                            "join tblArea a on r.intAreaID = a.intAreaID " +
                                                                            "order by strRoomID");
            return retSql.ToList();
        }
    }
}
