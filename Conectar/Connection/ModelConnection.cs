namespace Connection
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ModelConnection : DbContext
    {
        public ModelConnection()
            : base("name=ModelConnection")
        {
        }

        public virtual DbSet<consept> consept { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
