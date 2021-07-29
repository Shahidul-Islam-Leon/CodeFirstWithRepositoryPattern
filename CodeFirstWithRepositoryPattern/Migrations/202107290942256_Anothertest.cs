namespace CodeFirstWithRepositoryPattern.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Anothertest : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Categories", "AnotherTest", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Categories", "AnotherTest");
        }
    }
}
