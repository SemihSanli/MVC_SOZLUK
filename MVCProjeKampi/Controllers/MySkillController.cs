using BusinessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace MVCProjeKampi.Controllers
{
    public class MySkillController : Controller
    {
        // GET: MySkill
        MySkillManager ms = new MySkillManager();
        public ActionResult Index()
        {
         
            return View();
        }
        public ActionResult GetSkillList()
        {
            var skillValues = ms.GetAll();
            return View(skillValues);
        }
    }
}