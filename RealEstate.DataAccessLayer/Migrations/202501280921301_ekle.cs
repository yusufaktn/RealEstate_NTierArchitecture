namespace RealEstate.DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ekle : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TBL_OPPORTUNITY",
                c => new
                    {
                        OPPORTUNITY_ID = c.Int(nullable: false, identity: true),
                        PRODUCT_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.OPPORTUNITY_ID)
                .ForeignKey("dbo.TBL_PRODUCT", t => t.PRODUCT_ID, cascadeDelete: true)
                .Index(t => t.PRODUCT_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TBL_OPPORTUNITY", "PRODUCT_ID", "dbo.TBL_PRODUCT");
            DropIndex("dbo.TBL_OPPORTUNITY", new[] { "PRODUCT_ID" });
            DropTable("dbo.TBL_OPPORTUNITY");
        }
    }
}
