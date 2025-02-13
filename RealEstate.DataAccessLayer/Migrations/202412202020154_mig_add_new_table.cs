namespace RealEstate.DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_add_new_table : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TBL_CUSTOMER",
                c => new
                    {
                        CUSTOMER_ID = c.Int(nullable: false, identity: true),
                        CUSTOMER_NAME = c.String(),
                        CUSTOMER_SURNAME = c.String(),
                        CUSTOMER_MAIL = c.String(),
                        CUSTOMER_PHONE = c.String(),
                    })
                .PrimaryKey(t => t.CUSTOMER_ID);
            
            CreateTable(
                "dbo.TBL_PRODUCT",
                c => new
                    {
                        PRODUCT_ID = c.Int(nullable: false, identity: true),
                        PRODUCT_TYPE = c.String(),
                        PRODUCT_PRICE = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PRODCUT_TITLE = c.String(),
                        PRODUCT_SIZE = c.String(),
                    })
                .PrimaryKey(t => t.PRODUCT_ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TBL_PRODUCT");
            DropTable("dbo.TBL_CUSTOMER");
        }
    }
}
