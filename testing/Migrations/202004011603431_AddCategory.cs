namespace testing.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCategory : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        number_of_products = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            AlterColumn("dbo.Products", "image", c => c.Binary());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Products", "image", c => c.Byte(nullable: false));
            DropTable("dbo.Categories");
        }
    }
}
