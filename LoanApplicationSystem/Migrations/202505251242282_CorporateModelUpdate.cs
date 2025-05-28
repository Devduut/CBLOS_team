namespace LoanApplicationSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CorporateModelUpdate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.LoanApplications", "CompanyName", c => c.String(nullable: false));
            AddColumn("dbo.LoanApplications", "BusinessType", c => c.String());
            AddColumn("dbo.LoanApplications", "RegistrationNo", c => c.String());
            AddColumn("dbo.LoanApplications", "GSTIN", c => c.String());
            AddColumn("dbo.LoanApplications", "Industry", c => c.String());
            AddColumn("dbo.LoanApplications", "YearsInOperation", c => c.Int(nullable: false));
            AddColumn("dbo.LoanApplications", "Turnover", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.LoanApplications", "NetProfit", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.LoanApplications", "Collateral", c => c.String());
            DropColumn("dbo.LoanApplications", "FullName");
            DropColumn("dbo.LoanApplications", "Email");
            DropColumn("dbo.LoanApplications", "Phone");
            DropColumn("dbo.LoanApplications", "BusinessName");
            DropColumn("dbo.LoanApplications", "AnnualRevenue");
            DropColumn("dbo.LoanApplications", "UploadedFileName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.LoanApplications", "UploadedFileName", c => c.String());
            AddColumn("dbo.LoanApplications", "AnnualRevenue", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.LoanApplications", "BusinessName", c => c.String(nullable: false));
            AddColumn("dbo.LoanApplications", "Phone", c => c.String(nullable: false));
            AddColumn("dbo.LoanApplications", "Email", c => c.String(nullable: false));
            AddColumn("dbo.LoanApplications", "FullName", c => c.String(nullable: false));
            DropColumn("dbo.LoanApplications", "Collateral");
            DropColumn("dbo.LoanApplications", "NetProfit");
            DropColumn("dbo.LoanApplications", "Turnover");
            DropColumn("dbo.LoanApplications", "YearsInOperation");
            DropColumn("dbo.LoanApplications", "Industry");
            DropColumn("dbo.LoanApplications", "GSTIN");
            DropColumn("dbo.LoanApplications", "RegistrationNo");
            DropColumn("dbo.LoanApplications", "BusinessType");
            DropColumn("dbo.LoanApplications", "CompanyName");
        }
    }
}
