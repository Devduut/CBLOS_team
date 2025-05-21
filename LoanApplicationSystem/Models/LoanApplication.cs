using System;
using System.ComponentModel.DataAnnotations;

namespace LoanApplicationSystem.Models
{
    public enum ApplicationStatus
    {
        Pending,
        Approved,

    }
    public class LoanApplication
    {
        public int Id { get; set; }

        [Required]
        public string FullName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Phone { get; set; }

        [Required]
        public string BusinessName { get; set; }

        [Required]
        public decimal LoanAmount { get; set; }

        [Required]
        public string LoanPurpose { get; set; }

        [Required]
        public decimal AnnualRevenue { get; set; }

        [Required]
        public decimal ExistingDebt { get; set; }

        public string UploadedFileName { get; set; }

        public ApplicationStatus Status { get; set; } = ApplicationStatus.Pending;
        public DateTime SubmissionDAte { get; set; } = DateTime.Now;
    }
}