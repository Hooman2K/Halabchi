namespace HalabchiCRM
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    using System.ComponentModel.DataAnnotations;
    using System.Data.SqlClient;
    public class HalabchiDB : DbContext
    {
        // Your context has been configured to use a 'HalabchiDB' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'HalabchiCRM.HalabchiDB' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'HalabchiDB' 
        // connection string in the application configuration file.
        public HalabchiDB()
            : base("name=HalabchiDB")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<HalabchiDB, Migrations.Configuration>());
            SqlConnection.ClearAllPools();
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Setting> Settings { get; set; }
    }

    public class User
    {
        [Key,MaxLength(50)]
        public string UserName { get; set; }
        [MaxLength(50)]
        public string Password { get; set; }
        [MaxLength(50)]
        public string FName { get; set; }
        [MaxLength(50)]
        public string LName { get; set; }
        [MaxLength(11)]
        public string Mobile { get; set; }
        [MaxLength(50)]
        public string Email { get; set; }
        public byte SecurityQuestion { get; set; }
        [MaxLength(50)]
        public string SecurityQAnswer { get; set; }
        public bool IsAdmin { get; set; }
    }
    public class Setting
    {
        public int ID { get; set; }
        public bool AdminRegister { get; set; }
        public string Theme { get; set; }
    }
}