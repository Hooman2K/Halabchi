namespace HalabchiCRM.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<HalabchiCRM.HalabchiDB>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(HalabchiCRM.HalabchiDB context)
        {
            if (!context.Settings.Any())
            {
                Setting set = new Setting()
                {
                    AdminRegister = false,
                    Theme = "آبی"
                };
                context.Settings.Add(set);
                base.Seed(context);
            }
        }
    }
}
