using BusinessLayer.Concrete;
using DataAccessLayer.EntityFrameWork;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Web;
using System.Web.Mvc;

namespace MVCProjeKampi.Controllers
{
    public class WriterPanelContentController : Controller
    {
        // GET: WriterPanelContent
        ContentManager cm = new ContentManager(new EFContentDal());
        Context c = new Context();  
        public ActionResult MyContent(string p)
        {
            
            int id = 2;
            p = (string)Session["WriterMail"];
         // var writeridinfo=c.Writers.Where(x=>x.WriterMail == p).Select(y=>y.WriterID).FirstOrDefault();
           ViewBag.d = p;
            var contentValues = cm.GetListByWriter(id);
            return View(contentValues);
        }
        [HttpGet]
        public ActionResult AddContent(int id)
        {
            ViewBag.d = id;
            return View();
        }
        [HttpPost]
        public ActionResult AddContent(Content p)
        {
            string mail = (string)Session["WriterMail"];
           // var writeridinfo = c.Writers.Where(x => x.WriterMail == mail).Select(y => y.WriterID).FirstOrDefault();

            p.ContentDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            // p.WriterID=writeridinfo
            p.ContentStatus = true;
            cm.ContentAdd(p);
            return RedirectToAction("MyContent");
        }
    }
}