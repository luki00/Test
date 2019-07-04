namespace Test.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Hospitals", "SorDescribtion", c => c.String());
            DropColumn("dbo.Hospitals", "Describtion");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Hospitals", "Describtion", c => c.String());
            DropColumn("dbo.Hospitals", "SorDescribtion");
        }
    }
}
