namespace BaseApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddOlimpicGameDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Athlets",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        BirthDate = c.DateTime(nullable: false),
                        Weight = c.Double(nullable: false),
                        Score = c.Int(nullable: false),
                        Gender_Id = c.Int(),
                        SportType_Id = c.Int(),
                        Competition_Id = c.Int(),
                        Country_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Genders", t => t.Gender_Id)
                .ForeignKey("dbo.SportTypes", t => t.SportType_Id)
                .ForeignKey("dbo.Competitions", t => t.Competition_Id)
                .ForeignKey("dbo.Countries", t => t.Country_Id)
                .Index(t => t.Gender_Id)
                .Index(t => t.SportType_Id)
                .Index(t => t.Competition_Id)
                .Index(t => t.Country_Id);
            
            CreateTable(
                "dbo.Genders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Medals",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Degree = c.Int(nullable: false),
                        Name = c.Int(nullable: false),
                        Athlet_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Athlets", t => t.Athlet_Id)
                .Index(t => t.Athlet_Id);
            
            CreateTable(
                "dbo.SportTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Gender_Id = c.Int(),
                        SportType_Id = c.Int(),
                        WeightLimite_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Genders", t => t.Gender_Id)
                .ForeignKey("dbo.SportTypes", t => t.SportType_Id)
                .ForeignKey("dbo.WeightLimites", t => t.WeightLimite_Id)
                .Index(t => t.Gender_Id)
                .Index(t => t.SportType_Id)
                .Index(t => t.WeightLimite_Id);
            
            CreateTable(
                "dbo.WeightLimites",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MaxWeight = c.Double(nullable: false),
                        MinWeight = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Competitions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IsFinal = c.Boolean(nullable: false),
                        StartTime = c.DateTime(nullable: false),
                        SportType_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.SportTypes", t => t.SportType_Id)
                .Index(t => t.SportType_Id);
            
            CreateTable(
                "dbo.Countries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Athlets", "Country_Id", "dbo.Countries");
            DropForeignKey("dbo.Competitions", "SportType_Id", "dbo.SportTypes");
            DropForeignKey("dbo.Athlets", "Competition_Id", "dbo.Competitions");
            DropForeignKey("dbo.Athlets", "SportType_Id", "dbo.SportTypes");
            DropForeignKey("dbo.SportTypes", "WeightLimite_Id", "dbo.WeightLimites");
            DropForeignKey("dbo.SportTypes", "SportType_Id", "dbo.SportTypes");
            DropForeignKey("dbo.SportTypes", "Gender_Id", "dbo.Genders");
            DropForeignKey("dbo.Medals", "Athlet_Id", "dbo.Athlets");
            DropForeignKey("dbo.Athlets", "Gender_Id", "dbo.Genders");
            DropIndex("dbo.Competitions", new[] { "SportType_Id" });
            DropIndex("dbo.SportTypes", new[] { "WeightLimite_Id" });
            DropIndex("dbo.SportTypes", new[] { "SportType_Id" });
            DropIndex("dbo.SportTypes", new[] { "Gender_Id" });
            DropIndex("dbo.Medals", new[] { "Athlet_Id" });
            DropIndex("dbo.Athlets", new[] { "Country_Id" });
            DropIndex("dbo.Athlets", new[] { "Competition_Id" });
            DropIndex("dbo.Athlets", new[] { "SportType_Id" });
            DropIndex("dbo.Athlets", new[] { "Gender_Id" });
            DropTable("dbo.Countries");
            DropTable("dbo.Competitions");
            DropTable("dbo.WeightLimites");
            DropTable("dbo.SportTypes");
            DropTable("dbo.Medals");
            DropTable("dbo.Genders");
            DropTable("dbo.Athlets");
        }
    }
}
