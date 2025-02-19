using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using VitalLabels.Desktop.Models;

namespace VitalLabels.Desktop.Models
{
    public partial class SysproContext : DbContext
    {
        public SysproContext()
            : base("name=SysproContext")
        {
        }

        //public virtual DbSet<InvMaster> InvMaster { get; set; }
        //public virtual DbSet<LotDetail> LotDetail { get; set; }
        public virtual DbSet<ACBOuterModel> ACBOuterModel { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Ignore<ACBOuterModel>();
        }
    }
}
