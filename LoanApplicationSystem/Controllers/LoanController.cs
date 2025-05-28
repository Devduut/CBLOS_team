using System;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LoanApplicationSystem.Models;

namespace LoanApplicationSystem.Controllers
{
    public class LoanController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public ActionResult dashboardWithApply()
        {
            return View();
        }
        public ActionResult Apply()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Apply(LoanApplication model, HttpPostedFileBase uploadDocument)
        {
            if (ModelState.IsValid)
            {

                model.SubmissionDate = DateTime.Now;
                db.LoanApplications.Add(model);
                db.SaveChanges();

                return RedirectToAction("Success");
            }

            return View(model);
        }

        public ActionResult Success()
        {
            return View();
        }

        public ActionResult AdminList()
        {
            return View(db.LoanApplications.ToList());
        }

        [HttpPost]
        public ActionResult UpdateStatus(int ApplicationId, ApplicationStatus Status)
        {
            var application = db.LoanApplications.FirstOrDefault(a => a.Id == ApplicationId);
            if (application != null)
            {
                application.Status = Status;
                db.SaveChanges();
                TempData["Message"] = "Status updated successfully!";
            }
            return RedirectToAction("AdminList");
        }
    }
}