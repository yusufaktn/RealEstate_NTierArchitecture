namespace RealEstate.DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class güncelle2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TBL_COMMENT", "COMMENT_DATE", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.TBL_COMMENT", "COMMENT_DATE");
        }
    }
}
