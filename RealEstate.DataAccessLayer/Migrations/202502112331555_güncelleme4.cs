namespace RealEstate.DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class güncelleme4 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TBL_REALESTATE_CONSULTANT", "DETAIL", c => c.String(maxLength: 150));
            AddColumn("dbo.TBL_REALESTATE_CONSULTANT", "SPECIALIZATION", c => c.String(maxLength: 100));
            AddColumn("dbo.TBL_REALESTATE_CONSULTANT", "IMAGE", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.TBL_REALESTATE_CONSULTANT", "IMAGE");
            DropColumn("dbo.TBL_REALESTATE_CONSULTANT", "SPECIALIZATION");
            DropColumn("dbo.TBL_REALESTATE_CONSULTANT", "DETAIL");
        }
    }
}
