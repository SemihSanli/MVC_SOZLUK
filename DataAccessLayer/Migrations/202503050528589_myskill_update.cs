namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class myskill_update : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MySkills", "Skill1", c => c.String(maxLength: 50));
            AddColumn("dbo.MySkills", "Skill2", c => c.String(maxLength: 50));
            AddColumn("dbo.MySkills", "Skill3", c => c.String(maxLength: 50));
            AddColumn("dbo.MySkills", "Skill4", c => c.String(maxLength: 50));
            DropColumn("dbo.MySkills", "Skills");
        }
        
        public override void Down()
        {
            AddColumn("dbo.MySkills", "Skills", c => c.String(maxLength: 50));
            DropColumn("dbo.MySkills", "Skill4");
            DropColumn("dbo.MySkills", "Skill3");
            DropColumn("dbo.MySkills", "Skill2");
            DropColumn("dbo.MySkills", "Skill1");
        }
    }
}
