using System;
using System.ComponentModel.DataAnnotations;

namespace LoanApplicationSystem.Models
{
    public enum ApplicationStatus
    {
        Pending,
        Approved,
        Rejected
    }

    public class LoanApplication
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string CompanyName { get; set; }

        public string BusinessType { get; set; }

        public string RegistrationNo { get; set; }

        public string GSTIN { get; set; }

        public string Industry { get; set; }

        public int YearsInOperation { get; set; }

        [Required]
        public decimal LoanAmount { get; set; }

        [Required]
        public string LoanPurpose { get; set; }

        public decimal Turnover { get; set; }

        public decimal NetProfit { get; set; }

        public decimal ExistingDebt { get; set; }

        public string Collateral { get; set; }


        public ApplicationStatus Status { get; set; } = ApplicationStatus.Pending;

        public DateTime SubmissionDate { get; set; } = DateTime.Now;
    }
}