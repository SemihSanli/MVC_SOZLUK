namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_myskill : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MySkills",
                c => new
                    {
                        SkillID = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 20),
                        Surname = c.String(maxLength: 25),
                        Title = c.String(maxLength: 30),
                        Skills = c.String(maxLength: 50),
                        Images = c.String(maxLength: 400),
                    })
                .PrimaryKey(t => t.SkillID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.MySkills");
        }
    }
}
