namespace NewADO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddURL : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Departments", "addURL", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Departments", "addURL");
        }
    }
}
