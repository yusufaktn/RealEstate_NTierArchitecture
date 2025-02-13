namespace RealEstate.DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tanımlamalar : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TBL_CONTACT", "MAIL", c => c.String());
            AddColumn("dbo.TBL_PRODUCT", "CATEGORY_ID", c => c.Int(nullable: false));
            AlterColumn("dbo.TBL_CATEGORY", "CATEGORY_DETAILS", c => c.String(maxLength: 1000));
            AlterColumn("dbo.TBL_COMMENT", "COMMENT_DESCRIPTION", c => c.String(maxLength: 1000));
            AlterColumn("dbo.TBL_CONTACT", "MESSAGE", c => c.String(maxLength: 500));
            AlterColumn("dbo.TBL_CUSTOMER", "CUSTOMER_PHONE", c => c.String(maxLength: 11));
            AlterColumn("dbo.TBL_PRODUCT", "PRODCUT_TITLE", c => c.String(maxLength: 100));
            CreateIndex("dbo.TBL_PRODUCT", "CATEGORY_ID");
            CreateIndex("dbo.TBL_COMMENT", "CUSTOMER_ID");
            AddForeignKey("dbo.TBL_PRODUCT", "CATEGORY_ID", "dbo.TBL_CATEGORY", "CATEGORY_ID", cascadeDelete: true);
            AddForeignKey("dbo.TBL_COMMENT", "CUSTOMER_ID", "dbo.TBL_CUSTOMER", "CUSTOMER_ID", cascadeDelete: true);
            DropColumn("dbo.TBL_CONTACT", "SURNAME");
        }
        
        public override void Down()
        {
            AddColumn("dbo.TBL_CONTACT", "SURNAME", c => c.String());
            DropForeignKey("dbo.TBL_COMMENT", "CUSTOMER_ID", "dbo.TBL_CUSTOMER");
            DropForeignKey("dbo.TBL_PRODUCT", "CATEGORY_ID", "dbo.TBL_CATEGORY");
            DropIndex("dbo.TBL_COMMENT", new[] { "CUSTOMER_ID" });
            DropIndex("dbo.TBL_PRODUCT", new[] { "CATEGORY_ID" });
            AlterColumn("dbo.TBL_PRODUCT", "PRODCUT_TITLE", c => c.String());
            AlterColumn("dbo.TBL_CUSTOMER", "CUSTOMER_PHONE", c => c.String());
            AlterColumn("dbo.TBL_CONTACT", "MESSAGE", c => c.String());
            AlterColumn("dbo.TBL_COMMENT", "COMMENT_DESCRIPTION", c => c.String());
            AlterColumn("dbo.TBL_CATEGORY", "CATEGORY_DETAILS", c => c.String());
            DropColumn("dbo.TBL_PRODUCT", "CATEGORY_ID");
            DropColumn("dbo.TBL_CONTACT", "MAIL");
        }
    }
}
