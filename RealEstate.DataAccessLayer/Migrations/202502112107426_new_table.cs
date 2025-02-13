namespace RealEstate.DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class new_table : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TBL_REALESTATE_CONSULTANT",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        NAME = c.String(maxLength: 50),
                        SURNAME = c.String(maxLength: 50),
                        PHONE = c.String(maxLength: 50),
                        EMAIL = c.String(maxLength: 80),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TBL_REALESTATE_CONSULTANT");
        }
    }
}
