namespace NewADO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        DeptID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Location = c.String(),
                    })
                .PrimaryKey(t => t.DeptID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Departments");
        }
    }
}
