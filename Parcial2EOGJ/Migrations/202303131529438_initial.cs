namespace Parcial2EOGJ.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Contacts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Address = c.String(),
                        City = c.String(),
                        Country = c.String(),
                        Phone = c.String(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Countries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CountryName = c.String(),
                        State = c.String(),
                        City = c.String(),
                        Region = c.String(),
                        PostalCode = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Rols",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RolName = c.String(),
                        RolDescription = c.String(),
                        RolCode = c.String(),
                        RolType = c.String(),
                        Payment = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Services",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ServiceName = c.String(),
                        ServiceDescription = c.String(),
                        ServiceId = c.String(),
                        ServiceType = c.String(),
                        ServiceCost = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        Password = c.String(),
                        Email = c.String(),
                        PhoneNumber = c.String(),
                        Address = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Users");
            DropTable("dbo.Services");
            DropTable("dbo.Rols");
            DropTable("dbo.Countries");
            DropTable("dbo.Contacts");
        }
    }
}
