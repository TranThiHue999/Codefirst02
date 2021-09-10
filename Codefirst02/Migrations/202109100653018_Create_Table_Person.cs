namespace Codefirst02.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_Person : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Person",
                c => new
                    {
                        PersonID = c.String(nullable: false, maxLength: 128),
                        PersonName = c.String(),
                        Address = c.String(),
                    })
                .PrimaryKey(t => t.PersonID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Person");
        }
    }
}
