namespace TeachMe.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class userProfile : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UserProfiles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Email = c.String(),
                        Age = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Username = c.String(nullable: false, maxLength: 250),
                        Password = c.String(nullable: false, maxLength: 250),
                        CreatedOn = c.DateTime(nullable: false),
                        UpdateOn = c.DateTime(),
                        UserProfile_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.UserProfiles", t => t.UserProfile_Id)
                .Index(t => t.UserProfile_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "UserProfile_Id", "dbo.UserProfiles");
            DropIndex("dbo.Users", new[] { "UserProfile_Id" });
            DropTable("dbo.Users");
            DropTable("dbo.UserProfiles");
        }
    }
}
