namespace BcProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class adminUserUpdated : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AdminUsers", "Mail", c => c.String(nullable: false));
            AddColumn("dbo.AdminUsers", "Number", c => c.String(nullable: false));
            AddColumn("dbo.AdminUsers", "Adress", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AdminUsers", "Adress");
            DropColumn("dbo.AdminUsers", "Number");
            DropColumn("dbo.AdminUsers", "Mail");
        }
    }
}
