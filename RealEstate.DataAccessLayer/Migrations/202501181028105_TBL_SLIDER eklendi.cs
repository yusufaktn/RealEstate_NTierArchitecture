namespace RealEstate.DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TBL_SLIDEReklendi : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TBL_SLIDER",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        PRODUCT_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.TBL_PRODUCT", t => t.PRODUCT_ID, cascadeDelete: true)
                .Index(t => t.PRODUCT_ID);
            
            DropTable("dbo.TBL_FEATURESERVICE");
            DropTable("dbo.TBL_SUBSCRIBE");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.TBL_SUBSCRIBE",
                c => new
                    {
                        SUBSCRIBE_ID = c.Int(nullable: false, identity: true),
                        MAIL = c.String(),
                    })
                .PrimaryKey(t => t.SUBSCRIBE_ID);
            
            CreateTable(
                "dbo.TBL_FEATURESERVICE",
                c => new
                    {
                        FEATURE_ID = c.Int(nullable: false, identity: true),
                        TITLE = c.String(),
                        DESCRIPTION = c.String(),
                        IMAGE_ICON = c.String(),
                    })
                .PrimaryKey(t => t.FEATURE_ID);
            
            DropForeignKey("dbo.TBL_SLIDER", "PRODUCT_ID", "dbo.TBL_PRODUCT");
            DropIndex("dbo.TBL_SLIDER", new[] { "PRODUCT_ID" });
            DropTable("dbo.TBL_SLIDER");
        }
    }
}
