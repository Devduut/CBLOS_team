using System;
using System.Linq;
using System.Web.Mvc;
using LoanApplicationSystem.Models;

namespace LoanApplicationSystem.Controllers
{
    public class ApprovalController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public ActionResult Details(int applicationId)
        {
            var approvals = db.Approvals
                .Where(a => a.ApplicationId == applicationId)
                .OrderBy(a => a.ApprovalLevel)
                .ToList();

            ViewBag.ApplicationId = applicationId;
            return View(approvals);
        }

        [HttpPost]
        public ActionResult AddApproval(Approval approval)
        {
            approval.ApprovalDate = DateTime.Now;
            db.Approvals.Add(approval);
            db.SaveChanges();

            return RedirectToAction("Details", new { applicationId = approval.ApplicationId });
        }
    }
}