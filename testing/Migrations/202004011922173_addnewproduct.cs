namespace testing.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addnewproduct : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Products", "Image", c => c.String());
            AlterColumn("dbo.Products", "category_id", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Products", "category_id", c => c.Int(nullable: false));
            AlterColumn("dbo.Products", "Image", c => c.Binary());
        }
    }
}
