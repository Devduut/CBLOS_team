using System.Web;
using System.Web.Mvc;
using LoanApplicationSystem.Models;
using System.IO;
using System.Linq;

namespace LoanApplicationSystem.Controllers
{
    public class LoanController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public ActionResult Apply()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Apply(LoanApplication model, HttpPostedFileBase uploadDocument)
        {
            if (ModelState.IsValid)
            {
                if (uploadDocument != null && uploadDocument.ContentLength > 0)
                {
                    var fileName = Path.GetFileName(uploadDocument.FileName);
                    var path = Path.Combine(Server.MapPath("~/UploadedDocs/"), fileName);
                    uploadDocument.SaveAs(path);
                    model.UploadedFileName = fileName;
                }

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
    }
}