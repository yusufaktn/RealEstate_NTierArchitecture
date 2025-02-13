namespace RealEstate.DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class güncelle1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TBL_PRODUCT", "TYPE_ID", c => c.Int(nullable: false));
            CreateIndex("dbo.TBL_PRODUCT", "TYPE_ID");
            AddForeignKey("dbo.TBL_PRODUCT", "TYPE_ID", "dbo.TBL_TYPE", "TYPE_ID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TBL_PRODUCT", "TYPE_ID", "dbo.TBL_TYPE");
            DropIndex("dbo.TBL_PRODUCT", new[] { "TYPE_ID" });
            DropColumn("dbo.TBL_PRODUCT", "TYPE_ID");
        }
    }
}
