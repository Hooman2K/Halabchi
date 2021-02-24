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
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Contract> Contracts { get; set; }
        public virtual DbSet<Type> Types { get; set; }
        public virtual DbSet<Storage> Storages { get; set; }
        public virtual DbSet<StorageType> StorageTypes { get; set; }
        public virtual DbSet<PipeLine> PipeLines { get; set; }
        public virtual DbSet<ProductionFormulaName> ProductionFormulaNames { get; set; }
        public virtual DbSet<ProductionFormulaType> ProductionFormulaTypes { get; set; }
    }

    public class User
    {
        [Key, MaxLength(50)]
        public string UserName { get; set; }
        [MaxLength(50)]
        public string Password { get; set; }
        [MaxLength(50)]
        public string FName { get; set; }
        [MaxLength(50)]
        public string LName { get; set; }
        [MaxLength(25)]
        public string Mobile { get; set; }
        [MaxLength(50)]
        public string Email { get; set; }
        public byte SecurityQuestion { get; set; }
        [MaxLength(90)]
        public string SecurityQAnswer { get; set; }
        public bool IsAdmin { get; set; }
    }
    public class Setting
    {
        public int ID { get; set; }
        public bool AdminRegister { get; set; }
        [MaxLength(10)]
        public string Theme { get; set; }
    }
    public class Customer
    {
        public int ID { get; set; }
        [MaxLength(10)]
        public string CustomerID { get; set; }
        [MaxLength(10)]
        public string PostCode { get; set; }
        [MaxLength(15)]
        public string EconomyCode { get; set; }
        [MaxLength(50)]
        public string ManagerName { get; set; }
        [MaxLength(11)]
        public string Mobile { get; set; }
        [MaxLength(50)]
        public string FactoryName { get; set; }
        [MaxLength(50)]
        public string Brand { get; set; }
        [MaxLength(11)]
        public string Tell { get; set; }
        [MaxLength(11)]
        public string Fax { get; set; }
        [MaxLength(100)]
        public string Email { get; set; }
        [MaxLength(100)]
        public string WebSite { get; set; }
        [MaxLength(150)]
        public string Other { get; set; }
        public string Address { get; set; }

    }
    public class Contract
    {
        public int ID { get; set; }
        [MaxLength(10)]
        public string ContractID { get; set; }
        [MaxLength(10)]
        public string CustomerID { get; set; }
        [MaxLength(50)]
        public string FactoryName { get; set; }
        [MaxLength(10)]
        public string ContractDate { get; set; }
        [MaxLength(100)]
        public string ContractTitle { get; set; }
    }
    public class Type
    {
        public int ID { get; set; }
        [MaxLength(10)]
        public string CustomerID { get; set; }
        [MaxLength(10)]
        public string ContractID { get; set; }
        [MaxLength(50)]
        public string FactoryName { get; set; }
        [MaxLength(10)]
        public string ProductCode { get; set; }
        [MaxLength(50)]
        public string ProductName { get; set; }
        [MaxLength(20)]
        public string ProductUnit { get; set; }
    }
    public class Storage
    {
        public int ID { get; set; }
        [MaxLength(100)]
        public string StorageName { get; set; }
    }
    public class StorageType
    {
        public int ID { get; set; }
        [MaxLength(100)]
        public string StorageName { get; set; }
        [MaxLength(10)]
        public string ProductCode { get; set; }
        [MaxLength(50)]
        public string ProductName { get; set; }
        [MaxLength(20)]
        public string ProductUnit { get; set; }
        [MaxLength(10)]
        public string ProductType { get; set; }
        [MaxLength(100)]
        public string PipeLineName { get; set; }
    }
    public class PipeLine
    {
        public int ID { get; set; }
        [MaxLength(100)]
        public string PipeLineName { get; set; }
    }
    public class ProductionFormulaName
    {
        public int ID { get; set; }
        [MaxLength(50)]
        public string FormulaName { get; set; }
    }
    public class ProductionFormulaType
    {
        public int ID { get; set; }
        public int FormulaID { get; set; }
        [MaxLength(50)]
        public string ProductName { get; set; }
        [MaxLength(50)]
        public string MaterialName { get; set; }
        [MaxLength(20)]
        public string ProductUnitPerOne { get; set; }
    }
}