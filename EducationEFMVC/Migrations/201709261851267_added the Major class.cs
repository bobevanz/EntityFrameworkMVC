namespace EducationEFMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedtheMajorclass : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Majors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Students", "Majorid", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Students", "Majorid");
            DropTable("dbo.Majors");
        }
    }
}
