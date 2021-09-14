namespace Codefirst02.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Employee : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Person", "Company", c => c.String());
            AddColumn("dbo.Person", "Adress", c => c.String());
            AddColumn("dbo.Person", "Discriminator", c => c.String(nullable: false, maxLength: 128));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Person", "Discriminator");
            DropColumn("dbo.Person", "Adress");
            DropColumn("dbo.Person", "Company");
        }
    }
}
