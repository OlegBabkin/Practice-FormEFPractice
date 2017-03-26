using System.Data.Entity;
using WPFAppPractice.domain;

namespace FormEFPractice.DBConnection
{
    public partial class ProductDBContext : DbContext
    {
        public ProductDBContext() : base("name=ProductDBEntitiesConn") { }
        public ProductDBContext(string connectionName) : base("name=" + connectionName) { }

        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Product> Products { get; set; }
    }
}
