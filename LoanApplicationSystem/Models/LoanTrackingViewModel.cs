using System;

namespace LoanApplicationSystem.Models
{
    public class LoanTrackingViewModel
    {
        public int ApplicationId { get; set; }
        public string CompanyName { get; set; }
        public string LoanType { get; set; }
        public decimal LoanAmount { get; set; }
        public ApplicationStatus Status { get; set; } = ApplicationStatus.Pending;
        public DateTime SubmissionDate { get; set; }
    }
}