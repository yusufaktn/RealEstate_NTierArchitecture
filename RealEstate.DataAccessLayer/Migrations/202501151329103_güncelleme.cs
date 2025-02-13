namespace RealEstate.DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class güncelleme : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TBL_TYPE",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        NAME = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.ID);
            
            AddColumn("dbo.TBL_PRODUCT", "TYPE_ID", c => c.Int(nullable: false));
            AddColumn("dbo.TBL_PRODUCT", "TBL_TYPE_ID", c => c.Int());
            CreateIndex("dbo.TBL_PRODUCT", "TBL_TYPE_ID");
            AddForeignKey("dbo.TBL_PRODUCT", "TBL_TYPE_ID", "dbo.TBL_TYPE", "ID");
            DropColumn("dbo.TBL_PRODUCT", "PRODUCT_TYPE");
        }
        
        public override void Down()
        {
            AddColumn("dbo.TBL_PRODUCT", "PRODUCT_TYPE", c => c.String());
            DropForeignKey("dbo.TBL_PRODUCT", "TBL_TYPE_ID", "dbo.TBL_TYPE");
            DropIndex("dbo.TBL_PRODUCT", new[] { "TBL_TYPE_ID" });
            DropColumn("dbo.TBL_PRODUCT", "TBL_TYPE_ID");
            DropColumn("dbo.TBL_PRODUCT", "TYPE_ID");
            DropTable("dbo.TBL_TYPE");
        }
    }
}
