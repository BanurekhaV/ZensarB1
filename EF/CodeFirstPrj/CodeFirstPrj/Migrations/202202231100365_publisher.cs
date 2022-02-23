namespace CodeFirstPrj.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class publisher : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Publishers",
                c => new
                    {
                        PublisherId = c.Int(nullable: false, identity: true),
                        Publishername = c.String(),
                    })
                .PrimaryKey(t => t.PublisherId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Publishers");
        }
    }
}
