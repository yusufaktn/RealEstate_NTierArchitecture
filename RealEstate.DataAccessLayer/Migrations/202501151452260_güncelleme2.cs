namespace RealEstate.DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class güncelleme2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TBL_PRODUCT", "PRODUCT_TITLE", c => c.String(maxLength: 100));
            DropColumn("dbo.TBL_PRODUCT", "PRODCUT_TITLE");
        }
        
        public override void Down()
        {
            AddColumn("dbo.TBL_PRODUCT", "PRODCUT_TITLE", c => c.String(maxLength: 100));
            DropColumn("dbo.TBL_PRODUCT", "PRODUCT_TITLE");
        }
    }
}
