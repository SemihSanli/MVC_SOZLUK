using BusinessLayer.Concrete;
using DataAccessLayer.EntityFrameWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCProjeKampi.Controllers
{
    public class GalerryController : Controller
    {
        // GET: Galerry
        ImageFileManager ifm = new ImageFileManager(new EFImageFileDal());
        public ActionResult Index()
        {
            var files = ifm.GetList();
            return View(files) ;
        }
    }
}