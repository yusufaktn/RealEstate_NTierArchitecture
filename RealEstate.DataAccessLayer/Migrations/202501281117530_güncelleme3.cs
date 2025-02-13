namespace RealEstate.DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class güncelleme3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TBL_PRODUCT", "PRODUCT_IMAGE", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.TBL_PRODUCT", "PRODUCT_IMAGE");
        }
    }
}
