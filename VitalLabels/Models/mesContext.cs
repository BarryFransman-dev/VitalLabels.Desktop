namespace VitalLabels.Desktop.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class mesContext : DbContext
    {
        public mesContext()
            : base("name=MES")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Ignore<mesRecipeViewModel>();
        }
    }
}
