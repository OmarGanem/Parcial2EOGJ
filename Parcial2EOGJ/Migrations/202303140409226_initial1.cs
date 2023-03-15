namespace Parcial2EOGJ.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial1 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Contacts", "Phone");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Contacts", "Phone", c => c.String());
        }
    }
}
