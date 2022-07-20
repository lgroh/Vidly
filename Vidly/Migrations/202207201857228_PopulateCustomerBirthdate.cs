namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCustomerBirthdate : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET BirthDate = CAST('01/21/1980' AS DATETIME)  WHERE Id = 1");
        }
        
        public override void Down()
        {
        }
    }
}
