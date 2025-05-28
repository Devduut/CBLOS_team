using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LoanApplicationSystem.Models
{
    public enum ApprovalStatus
    {
        Pending,
        Approved,
        Rejected
    }

    public class Approval
    {
        [Key]
        public int ApprovalId { get; set; }

        [ForeignKey("LoanApplication")]
        public int ApplicationId { get; set; }
        public LoanApplication LoanApplication { get; set; }

        public int ApproverId { get; set; }

        public int ApprovalLevel { get; set; }

        public ApprovalStatus ApprovalStatus { get; set; }

        public string Comments { get; set; }

        public DateTime ApprovalDate { get; set; } = DateTime.Now;
    }
}