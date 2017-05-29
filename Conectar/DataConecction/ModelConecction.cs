namespace DataConecction
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ModelConecction : DbContext
    {
        public ModelConecction()
            : base("name=ModelConecction")
        {
        }

        public virtual DbSet<consept> consept { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
