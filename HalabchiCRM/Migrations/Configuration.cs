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
            AutomaticMigrationDataLossAllowed = true;
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
            if (!context.PipeLines.Any())
            {
                PipeLine pipe = new PipeLine()
                {
                    PipeLineName = "بدون خط تولید"
                };
                context.PipeLines.Add(pipe);
                base.Seed(context);
            }
            if(!context.Storages.Any())
            {
                Storage storage = new Storage()
                {
                    StorageName = "مواد اولیه"
                };
                context.Storages.Add(storage);
                base.Seed(context);
            }
            if(!context.TolidHalabGhotis.Any())
            {
                TolidHalabGhoti thg = new TolidHalabGhoti()
                {
                    Year = 0,
                    Month = 0,
                    Day = 0,
                    Date = "0000/00/00",
                    PipeLineName = "بدون خط تولید",
                    MojodiAval = 0,
                    Tolid = 0,
                    JamKol = 0,
                    TahvilAnbar = 0,
                    MandeAkhar = 0,
                };
                context.TolidHalabGhotis.Add(thg);
                base.Seed(context);
            }
        }
    }
}
