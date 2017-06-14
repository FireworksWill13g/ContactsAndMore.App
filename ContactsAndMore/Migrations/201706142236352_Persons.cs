namespace ContactsAndMore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Persons : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.People", "Active", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.People", "Active");
        }
    }
}
