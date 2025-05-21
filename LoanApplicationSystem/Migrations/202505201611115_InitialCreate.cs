namespace LoanApplicationSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.LoanApplications",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FullName = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        Phone = c.String(nullable: false),
                        BusinessName = c.String(nullable: false),
                        LoanAmount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        LoanPurpose = c.String(nullable: false),
                        AnnualRevenue = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ExistingDebt = c.Decimal(nullable: false, precision: 18, scale: 2),
                        UploadedFileName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.LoanApplications");
        }
    }
}
