namespace VitalLabels.Desktop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LotDetail")]
    public partial class LotDetail
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(30)]
        public string StockCode { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string Warehouse { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string Lot { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(20)]
        public string Bin { get; set; }

        public decimal NextTrnLine { get; set; }

        public decimal OrigQtyReceived { get; set; }

        public decimal QtyOnHand { get; set; }

        public decimal QtyToShip { get; set; }

        [Required]
        [StringLength(5)]
        public string Version { get; set; }

        [Required]
        [StringLength(5)]
        public string Release { get; set; }

        public DateTime? ExpiryDate { get; set; }

        public DateTime? CreationDate { get; set; }

        [Required]
        [StringLength(32)]
        public string DrawOfficeNum { get; set; }

        public DateTime? LastTrnDate { get; set; }

        [Required]
        [StringLength(10)]
        public string ArchiveFilename { get; set; }

        public decimal QtyInTransit { get; set; }

        [Required]
        [StringLength(1)]
        public string LotHoldFlag { get; set; }

        [Required]
        [StringLength(40)]
        public string Note { get; set; }

        [Required]
        [StringLength(1)]
        public string EccDummy { get; set; }

        public decimal QtyAwaitingCredit { get; set; }

        public decimal QtyReserved { get; set; }

        [Required]
        [StringLength(50)]
        public string SupplierLot { get; set; }

        public decimal ProductShelfLife { get; set; }

        public decimal InternalShelfLife { get; set; }

        public DateTime? UseByDate { get; set; }

        public DateTime? SellByDate { get; set; }

        public DateTime? InternalExpiryDate { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] TimeStamp { get; set; }

        public DateTime? ManufactureDate { get; set; }

        public DateTime? DispatchDate { get; set; }

        public DateTime? BestBeforeDate { get; set; }

        [Required]
        [StringLength(1)]
        public string PrdRecallFlag { get; set; }

        [Required]
        [StringLength(6)]
        public string ReasonCode { get; set; }

        public virtual InvMaster InvMaster { get; set; }
    }
}
