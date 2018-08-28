namespace aspmvc.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddcolumnNametoCustomers : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "Birthdate", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "Birthdate");
        }
    }
}
