namespace VitalLabels.Desktop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("InvMaster")]
    public partial class InvMaster
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public InvMaster()
        {
            LotDetail = new HashSet<LotDetail>();
        }

        [Key]
        [StringLength(30)]
        public string StockCode { get; set; }

        [Required]
        [StringLength(50)]
        public string Description { get; set; }

        [Required]
        [StringLength(100)]
        public string LongDesc { get; set; }

        [Required]
        [StringLength(20)]
        public string AlternateKey1 { get; set; }

        [Required]
        [StringLength(20)]
        public string AlternateKey2 { get; set; }

        [Required]
        [StringLength(20)]
        public string EccUser { get; set; }

        [Required]
        [StringLength(10)]
        public string StockUom { get; set; }

        [Required]
        [StringLength(10)]
        public string AlternateUom { get; set; }

        [Required]
        [StringLength(10)]
        public string OtherUom { get; set; }

        public decimal ConvFactAltUom { get; set; }

        [Required]
        [StringLength(1)]
        public string ConvMulDiv { get; set; }

        public decimal ConvFactOthUom { get; set; }

        [Required]
        [StringLength(1)]
        public string MulDiv { get; set; }

        public decimal Mass { get; set; }

        public decimal Volume { get; set; }

        public decimal Decimals { get; set; }

        [Required]
        [StringLength(1)]
        public string PriceCategory { get; set; }

        [Required]
        [StringLength(1)]
        public string PriceMethod { get; set; }

        [Required]
        [StringLength(15)]
        public string Supplier { get; set; }

        public decimal CycleCount { get; set; }

        [Required]
        [StringLength(20)]
        public string ProductClass { get; set; }

        [Required]
        [StringLength(3)]
        public string TaxCode { get; set; }

        [Required]
        [StringLength(3)]
        public string OtherTaxCode { get; set; }

        [Required]
        [StringLength(10)]
        public string ListPriceCode { get; set; }

        [Required]
        [StringLength(1)]
        public string SerialMethod { get; set; }

        [Required]
        [StringLength(1)]
        public string InterfaceFlag { get; set; }

        [Required]
        [StringLength(1)]
        public string KitType { get; set; }

        public decimal LowLevelCode { get; set; }

        [Required]
        [StringLength(20)]
        public string Buyer { get; set; }

        [Required]
        [StringLength(20)]
        public string Planner { get; set; }

        [Required]
        [StringLength(1)]
        public string TraceableType { get; set; }

        [Required]
        [StringLength(1)]
        public string MpsFlag { get; set; }

        [Required]
        [StringLength(1)]
        public string BulkIssueFlag { get; set; }

        [Required]
        [StringLength(1)]
        public string AbcClass { get; set; }

        public decimal LeadTime { get; set; }

        [Required]
        [StringLength(1)]
        public string StockMovementReq { get; set; }

        [Required]
        [StringLength(1)]
        public string ClearingFlag { get; set; }

        public DateTime? SupercessionDate { get; set; }

        [Required]
        [StringLength(1)]
        public string AbcAnalysisReq { get; set; }

        [Required]
        [StringLength(1)]
        public string AbcCostingReq { get; set; }

        [Required]
        [StringLength(10)]
        public string CostUom { get; set; }

        public decimal MinPricePct { get; set; }

        public decimal LabourCost { get; set; }

        public decimal MaterialCost { get; set; }

        public decimal FixOverhead { get; set; }

        public decimal VariableOverhead { get; set; }

        [Required]
        [StringLength(1)]
        public string PartCategory { get; set; }

        [Required]
        [StringLength(32)]
        public string DrawOfficeNum { get; set; }

        [Required]
        [StringLength(10)]
        public string WarehouseToUse { get; set; }

        [Required]
        [StringLength(1)]
        public string BuyingRule { get; set; }

        public decimal SpecificGravity { get; set; }

        public decimal ImplosionNum { get; set; }

        public decimal Ebq { get; set; }

        public decimal ComponentCount { get; set; }

        public decimal FixTimePeriod { get; set; }

        public decimal PanSize { get; set; }

        public decimal DockToStock { get; set; }

        [Required]
        [StringLength(1)]
        public string OutputMassFlag { get; set; }

        public decimal ShelfLife { get; set; }

        [Required]
        [StringLength(5)]
        public string Version { get; set; }

        [Required]
        [StringLength(5)]
        public string Release { get; set; }

        public decimal DemandTimeFence { get; set; }

        [Required]
        [StringLength(1)]
        public string MakeToOrderFlag { get; set; }

        public decimal ManufLeadTime { get; set; }

        [Required]
        [StringLength(1)]
        public string GrossReqRule { get; set; }

        public decimal PercentageYield { get; set; }

        public decimal AbcPreProd { get; set; }

        public decimal AbcManufacturing { get; set; }

        public decimal AbcSales { get; set; }

        public decimal AbcCumPreProd { get; set; }

        public decimal AbcCumManuf { get; set; }

        [Required]
        [StringLength(35)]
        public string WipCtlGlCode { get; set; }

        [Required]
        [StringLength(30)]
        public string ResourceCode { get; set; }

        [Required]
        [StringLength(3)]
        public string GstTaxCode { get; set; }

        [Required]
        [StringLength(1)]
        public string PrcInclGst { get; set; }

        [Required]
        [StringLength(1)]
        public string SerEntryAtSale { get; set; }

        [Required]
        [StringLength(1)]
        public string StpSelection { get; set; }

        [Required]
        [StringLength(30)]
        public string UserField1 { get; set; }

        public decimal UserField2 { get; set; }

        [Required]
        [StringLength(1)]
        public string UserField3 { get; set; }

        [Required]
        [StringLength(1)]
        public string UserField4 { get; set; }

        [Required]
        [StringLength(1)]
        public string UserField5 { get; set; }

        [Required]
        [StringLength(15)]
        public string TariffCode { get; set; }

        [Required]
        [StringLength(1)]
        public string SupplementaryUnit { get; set; }

        [Required]
        [StringLength(1)]
        public string EbqPan { get; set; }

        public decimal StdLandedCost { get; set; }

        [Required]
        [StringLength(1)]
        public string LctRequired { get; set; }

        [Required]
        [StringLength(8)]
        public string StdLctRoute { get; set; }

        [Required]
        [StringLength(1)]
        public string IssMultLotsFlag { get; set; }

        [Required]
        [StringLength(1)]
        public string InclInStrValid { get; set; }

        public decimal StdLabCostsBill { get; set; }

        [Required]
        [StringLength(1)]
        public string PhantomIfComp { get; set; }

        [Required]
        [StringLength(3)]
        public string CountryOfOrigin { get; set; }

        [Required]
        [StringLength(1)]
        public string StockOnHold { get; set; }

        [Required]
        [StringLength(6)]
        public string StockOnHoldReason { get; set; }

        [Required]
        [StringLength(1)]
        public string EccFlag { get; set; }

        [Required]
        [StringLength(1)]
        public string StockAndAltUm { get; set; }

        public decimal AltUnitChar { get; set; }

        [Required]
        [StringLength(1)]
        public string JobsOnHold { get; set; }

        [Required]
        [StringLength(1)]
        public string JobHoldAllocs { get; set; }

        [Required]
        [StringLength(1)]
        public string PurchOnHold { get; set; }

        [Required]
        [StringLength(1)]
        public string SalesOnHold { get; set; }

        [Required]
        [StringLength(1)]
        public string MaintOnHold { get; set; }

        [Required]
        [StringLength(1)]
        public string BatchBill { get; set; }

        [Required]
        [StringLength(1)]
        public string BlanketPoExists { get; set; }

        [Required]
        [StringLength(1)]
        public string CallOffBpoExists { get; set; }

        [Required]
        [StringLength(10)]
        public string DistWarehouseToUse { get; set; }

        [Required]
        [StringLength(10)]
        public string JobClassification { get; set; }

        public decimal SubContractCost { get; set; }

        public DateTime? DateStkAdded { get; set; }

        [Required]
        [StringLength(1)]
        public string InspectionFlag { get; set; }

        [Required]
        [StringLength(35)]
        public string SerialPrefix { get; set; }

        [Required]
        [StringLength(15)]
        public string SerialSuffix { get; set; }

        [Required]
        [StringLength(1)]
        public string ReturnableItem { get; set; }

        [Required]
        [StringLength(10)]
        public string ProductGroup { get; set; }

        [Required]
        [StringLength(1)]
        public string PriceType { get; set; }

        [Required]
        [StringLength(1)]
        public string Basis { get; set; }

        [Required]
        [StringLength(1)]
        public string ManualCostFlag { get; set; }

        [Required]
        [StringLength(10)]
        public string ManufactureUom { get; set; }

        public decimal ConvFactMuM { get; set; }

        [Required]
        [StringLength(1)]
        public string ManMulDiv { get; set; }

        public decimal LookAheadWin { get; set; }

        public decimal LoadingFactor { get; set; }

        [Required]
        [StringLength(3)]
        public string SupplUnitCode { get; set; }

        [Required]
        [StringLength(20)]
        public string StorageSecurity { get; set; }

        [Required]
        [StringLength(20)]
        public string StorageHazard { get; set; }

        [Required]
        [StringLength(20)]
        public string StorageCondition { get; set; }

        public decimal ProductShelfLife { get; set; }

        public decimal InternalShelfLife { get; set; }

        [Required]
        [StringLength(1)]
        public string AltMethodFlag { get; set; }

        [Required]
        [StringLength(1)]
        public string AltSisoFlag { get; set; }

        [Required]
        [StringLength(1)]
        public string AltReductionFlag { get; set; }

        [Required]
        [StringLength(1)]
        public string WithTaxExpenseType { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] TimeStamp { get; set; }

        [Required]
        [StringLength(1)]
        public string UsesPrefSupplier { get; set; }

        [Required]
        [StringLength(1)]
        public string PrdRecallFlag { get; set; }

        [Required]
        [StringLength(40)]
        public string OnHoldReason { get; set; }

        public decimal SpecificGravity6 { get; set; }

        public decimal SuppUnitFactor { get; set; }

        [Required]
        [StringLength(1)]
        public string SuppUnitsMulDiv { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LotDetail> LotDetail { get; set; }
    }
}
