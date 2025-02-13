namespace RealEstate.DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_new_table_2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TBL_COMMENT",
                c => new
                    {
                        COMMENT_ID = c.Int(nullable: false, identity: true),
                        COMMENT_DESCRIPTION = c.String(),
                        CUSTOMER_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.COMMENT_ID);
            
            CreateTable(
                "dbo.TBL_CONTACT",
                c => new
                    {
                        CONTACT_ID = c.Int(nullable: false, identity: true),
                        NAME = c.String(),
                        SURNAME = c.String(),
                        MESSAGE = c.String(),
                        DATE = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.CONTACT_ID);
            
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
            
            CreateTable(
                "dbo.TBL_SUBSCRIBE",
                c => new
                    {
                        SUBSCRIBE_ID = c.Int(nullable: false, identity: true),
                        MAIL = c.String(),
                    })
                .PrimaryKey(t => t.SUBSCRIBE_ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TBL_SUBSCRIBE");
            DropTable("dbo.TBL_FEATURESERVICE");
            DropTable("dbo.TBL_CONTACT");
            DropTable("dbo.TBL_COMMENT");
        }
    }
}
