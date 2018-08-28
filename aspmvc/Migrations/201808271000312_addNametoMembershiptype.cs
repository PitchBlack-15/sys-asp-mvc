namespace aspmvc.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addNametoMembershiptype : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MembershipTypes", "Name", c => c.String(nullable: false, maxLength: 60));
            Sql("Update MembershipTypes SET Name = 'Pay as You Go' where ID = 1");
            Sql("Update MembershipTypes SET Name = 'Monthly' where ID = 2");
            Sql("Update MembershipTypes SET Name = 'Quarterly' where ID = 3");
            Sql("Update MembershipTypes SET Name = 'Annually' where ID = 4");
        }
        
        public override void Down()
        {
            DropColumn("dbo.MembershipTypes", "Name");
        }
    }
}
