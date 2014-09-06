namespace Atm.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CardAccounts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        cardNumber = c.String(maxLength: 10),
                        cardPin = c.String(maxLength: 4),
                        Balance = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.CardAccounts");
        }
    }
}
