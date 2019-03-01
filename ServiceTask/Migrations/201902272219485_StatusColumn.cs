namespace ServiceTask.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class StatusColumn : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tasks", "Status", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Tasks", "Status");
        }
    }
}
