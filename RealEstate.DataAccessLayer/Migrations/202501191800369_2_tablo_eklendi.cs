namespace RealEstate.DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _2_tablo_eklendi : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TBL_FEATURE",
                c => new
                    {
                        FEATURE_ID = c.Int(nullable: false, identity: true),
                        FEATURE_NAME = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.FEATURE_ID);
            
            CreateTable(
                "dbo.TBL_PRODUCT_FEATURES",
                c => new
                    {
                        PRODUCT_F_ID = c.Int(nullable: false, identity: true),
                        PRODUCT_ID = c.Int(nullable: false),
                        FEATURE_ID = c.Int(nullable: false),
                        QUANTITIY = c.String(),
                    })
                .PrimaryKey(t => t.PRODUCT_F_ID)
                .ForeignKey("dbo.TBL_FEATURE", t => t.FEATURE_ID, cascadeDelete: true)
                .ForeignKey("dbo.TBL_PRODUCT", t => t.PRODUCT_ID, cascadeDelete: true)
                .Index(t => t.PRODUCT_ID)
                .Index(t => t.FEATURE_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TBL_PRODUCT_FEATURES", "PRODUCT_ID", "dbo.TBL_PRODUCT");
            DropForeignKey("dbo.TBL_PRODUCT_FEATURES", "FEATURE_ID", "dbo.TBL_FEATURE");
            DropIndex("dbo.TBL_PRODUCT_FEATURES", new[] { "FEATURE_ID" });
            DropIndex("dbo.TBL_PRODUCT_FEATURES", new[] { "PRODUCT_ID" });
            DropTable("dbo.TBL_PRODUCT_FEATURES");
            DropTable("dbo.TBL_FEATURE");
        }
    }
}
