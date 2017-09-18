namespace EducationEFMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedPhoneandEmailtostudent : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "Email", c => c.String());
            AddColumn("dbo.Students", "Phone", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Students", "Phone");
            DropColumn("dbo.Students", "Email");
        }
    }
}
