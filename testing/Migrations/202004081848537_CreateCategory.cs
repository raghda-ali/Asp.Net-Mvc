namespace testing.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateCategory : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "category_id1", c => c.Int());
            CreateIndex("dbo.Products", "category_id1");
            AddForeignKey("dbo.Products", "category_id1", "dbo.Categories", "id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "category_id1", "dbo.Categories");
            DropIndex("dbo.Products", new[] { "category_id1" });
            DropColumn("dbo.Products", "category_id1");
        }
    }
}
