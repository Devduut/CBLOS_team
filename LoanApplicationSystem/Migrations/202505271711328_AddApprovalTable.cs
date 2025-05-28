namespace LoanApplicationSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddApprovalTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Approvals",
                c => new
                    {
                        ApprovalId = c.Int(nullable: false, identity: true),
                        ApplicationId = c.Int(nullable: false),
                        ApproverId = c.Int(nullable: false),
                        ApprovalLevel = c.Int(nullable: false),
                        ApprovalStatus = c.Int(nullable: false),
                        Comments = c.String(),
                        ApprovalDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ApprovalId)
                .ForeignKey("dbo.LoanApplications", t => t.ApplicationId, cascadeDelete: true)
                .Index(t => t.ApplicationId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Approvals", "ApplicationId", "dbo.LoanApplications");
            DropIndex("dbo.Approvals", new[] { "ApplicationId" });
            DropTable("dbo.Approvals");
        }
    }
}
