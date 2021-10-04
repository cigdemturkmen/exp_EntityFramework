namespace k2_CodeFirstWithMigrations.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TCAddedToStudent : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "TCKN", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Students", "TCKN");
        }
    }
}
