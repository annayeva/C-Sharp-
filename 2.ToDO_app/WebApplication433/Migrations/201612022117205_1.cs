namespace WebApplication433.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Todoes", "TimeOfCompletion", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Todoes", "TimeOfCompletion");
        }
    }
}
