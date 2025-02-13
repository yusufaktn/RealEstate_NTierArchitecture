namespace RealEstate.DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class yeni_tablo_TBL_TYPE : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TBL_TYPE",
                c => new
                    {
                        TYPE_ID = c.Int(nullable: false, identity: true),
                        TYPE_NAME = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.TYPE_ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TBL_TYPE");
        }
    }
}
