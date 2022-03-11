namespace Day4EFCodeFirstPrj.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class propertychange : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TblCar", "CarName", c => c.String());
            DropColumn("dbo.TblCar", "Catname");
        }
        
        public override void Down()
        {
            AddColumn("dbo.TblCar", "Catname", c => c.String());
            DropColumn("dbo.TblCar", "CarName");
        }
    }
}
