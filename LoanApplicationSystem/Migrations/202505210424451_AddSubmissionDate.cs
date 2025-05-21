namespace LoanApplicationSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddSubmissionDate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.LoanApplications", "Status", c => c.Int(nullable: false));
            AddColumn("dbo.LoanApplications", "SubmissionDAte", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.LoanApplications", "SubmissionDAte");
            DropColumn("dbo.LoanApplications", "Status");
        }
    }
}
