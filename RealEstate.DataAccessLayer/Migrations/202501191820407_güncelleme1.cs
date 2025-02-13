namespace RealEstate.DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class güncelleme1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TBL_PRODUCT", "PRODUCT_SIZE", c => c.String(maxLength: 50));
            AddColumn("dbo.TBL_PRODUCT", "PRODUCT_DESCRIPTION", c => c.String(maxLength: 108));
        }
        
        public override void Down()
        {
            DropColumn("dbo.TBL_PRODUCT", "PRODUCT_DESCRIPTION");
            DropColumn("dbo.TBL_PRODUCT", "PRODUCT_SIZE");
        }
    }
}
