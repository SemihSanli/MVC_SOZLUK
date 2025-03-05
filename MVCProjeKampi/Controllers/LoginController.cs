using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
namespace MVCProjeKampi.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Admin p)
        {
            Context c = new Context();
            var adminuserInfo=c.Admins.FirstOrDefault(x=>x.AdminUserName==p.AdminUserName && x.AdminPassword==p.AdminPassword);
            if(adminuserInfo != null)
            {
                FormsAuthentication.SetAuthCookie(adminuserInfo.AdminUserName,false);
                Session["AdminUserName"] = adminuserInfo.AdminUserName;
                return RedirectToAction("Index", "AdminCategory");
            }
            else
            {
                return RedirectToAction("Index");
            }
            
        }
        [HttpGet]
        public ActionResult WriterLogin()
        {
            return View();
        }
        [HttpPost]
        public ActionResult WriterLogin(Writer p)
        {
            Context c = new Context();
            var writeruserInfo = c.Writers.FirstOrDefault(x => x.WriterMail == p.WriterMail && x.WriterPassword == p.WriterPassword);
            if (writeruserInfo != null)
            {
                FormsAuthentication.SetAuthCookie(writeruserInfo.WriterMail, false);
                Session["WriterMail"] = writeruserInfo.WriterMail;
                return RedirectToAction("MyContent", "WriterPanelContent");
            }
            else
            {
                return RedirectToAction("WriterLogin");
            }
            
        }
       // public ActionResult LogOut()
        //{
        //    //FormsAuthentication.SignOut();
        //    //Session.Abandon();
        //    //return RedirectToAction("Headings", "Default");
        //}
    }
}