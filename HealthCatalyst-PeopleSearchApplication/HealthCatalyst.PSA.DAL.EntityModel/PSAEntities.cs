namespace HealthCatalyst.PSA.DAL.EntityModel
{
    using HealthCatalyst.PSA.DAL.EntityModel.Init;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class PSAEntities : DbContext
    {
        // Your context has been configured to use a 'PSAEntities' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'HealthCatalyst.PSA.DAL.EntityModel.PSAEntities' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'PSAEntities' 
        // connection string in the application configuration file.
        public PSAEntities()
            : base("name=PSAEntities")
        {
            //seeding data
            Database.SetInitializer(new PSAEntityInitializer());
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.
        public DbSet<Person> Person { get; set; }
        public DbSet<PersonContactInformation> PersonContactInformation { get; set; }
        public DbSet<PersonInterest> PersonInterest { get; set; }

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
        protected override void OnModelCreating(DbModelBuilder ModelBuilder)
        {
            //Configure Domain classes using fluent API here.
            base.OnModelCreating(ModelBuilder);
        }

    }

}

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
