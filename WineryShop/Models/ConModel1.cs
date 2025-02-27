namespace WineryShop.Core.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class ConModel11 : DbContext
    {
        // Your context has been configured to use a 'ConModel111' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'WineryShop.Models.ConModel111' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'ConModel111' 
        // connection string in the application configuration file.
        public ConModel11()
            : base("name=ConModel111")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }

        public virtual DbSet<Wine> Wines { get; set; }
        public virtual DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        public virtual DbSet<Order> Orders { get; set; }

        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Login> Logins { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}