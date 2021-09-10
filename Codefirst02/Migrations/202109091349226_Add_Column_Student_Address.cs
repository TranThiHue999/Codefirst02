namespace Codefirst02.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_Column_Student_Address : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "Address", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Students", "Address");
        }
    }
}
