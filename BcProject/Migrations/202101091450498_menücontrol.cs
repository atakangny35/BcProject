namespace BcProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class menücontrol : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Works", "MenüControl", c => c.Boolean(nullable: false));
            DropColumn("dbo.Works", "main");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Works", "main", c => c.Boolean(nullable: false));
            DropColumn("dbo.Works", "MenüControl");
        }
    }
}
