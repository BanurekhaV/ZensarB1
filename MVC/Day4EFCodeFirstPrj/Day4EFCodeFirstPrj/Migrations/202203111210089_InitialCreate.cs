namespace Day4EFCodeFirstPrj.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TblCar",
                c => new
                    {
                        Carno = c.Int(nullable: false, identity: true),
                        Catname = c.String(),
                        Cartype = c.String(),
                    })
                .PrimaryKey(t => t.Carno);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TblCar");
        }
    }
}
