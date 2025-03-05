namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_update_message : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Messages", "Receiver", c => c.String(maxLength: 150));
            AlterColumn("dbo.Messages", "MessageContent", c => c.String(maxLength: 150));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Messages", "MessageContent", c => c.String(maxLength: 50));
            AlterColumn("dbo.Messages", "Receiver", c => c.String(maxLength: 50));
        }
    }
}
