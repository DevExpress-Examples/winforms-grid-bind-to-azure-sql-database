namespace DXApplication {
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using DXApplication.Data;

    public partial class AdventureWorksLTContext : DbContext {
        public AdventureWorksLTContext()
            : base(ConnectionSettings.GetConnectionString()) {
        }
        public virtual DbSet<Product> Products { get; set; }
    }
}
