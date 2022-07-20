namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateCustomerBirthdate1 : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET BirthDate = NULL  WHERE Id = 2");
        }
        
        public override void Down()
        {
        }
    }
}
