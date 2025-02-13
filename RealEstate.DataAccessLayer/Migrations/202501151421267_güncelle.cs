namespace RealEstate.DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class güncelle : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.TBL_PRODUCT", "TBL_TYPE_ID", "dbo.TBL_TYPE");
            DropIndex("dbo.TBL_PRODUCT", new[] { "TBL_TYPE_ID" });
            DropColumn("dbo.TBL_PRODUCT", "PRODUCT_SIZE");
            DropColumn("dbo.TBL_PRODUCT", "TYPE_ID");
            DropColumn("dbo.TBL_PRODUCT", "TBL_TYPE_ID");
            DropTable("dbo.TBL_TYPE");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.TBL_TYPE",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        NAME = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.ID);
            
            AddColumn("dbo.TBL_PRODUCT", "TBL_TYPE_ID", c => c.Int());
            AddColumn("dbo.TBL_PRODUCT", "TYPE_ID", c => c.Int(nullable: false));
            AddColumn("dbo.TBL_PRODUCT", "PRODUCT_SIZE", c => c.String());
            CreateIndex("dbo.TBL_PRODUCT", "TBL_TYPE_ID");
            AddForeignKey("dbo.TBL_PRODUCT", "TBL_TYPE_ID", "dbo.TBL_TYPE", "ID");
        }
    }
}
