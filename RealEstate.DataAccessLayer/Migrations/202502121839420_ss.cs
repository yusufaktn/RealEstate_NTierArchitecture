namespace RealEstate.DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ss : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.TBL_REALESTATE_CONSULTANT", "DETAIL", c => c.String(maxLength: 350));
            AlterColumn("dbo.TBL_REALESTATE_CONSULTANT", "IMAGE", c => c.String(maxLength: 250));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.TBL_REALESTATE_CONSULTANT", "IMAGE", c => c.String());
            AlterColumn("dbo.TBL_REALESTATE_CONSULTANT", "DETAIL", c => c.String(maxLength: 150));
        }
    }
}
