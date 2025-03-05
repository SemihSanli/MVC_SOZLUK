using BusinessLayer.Concrete;
using DataAccessLayer.EntityFrameWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services.Description;

namespace MVCProjeKampi.Controllers
{
    public class MessageController : Controller
    {
        // GET: Message
        MessageManager mm = new MessageManager(new EFMessageDal());
        public ActionResult Inbox()
        {
            var messageList =mm.GetListInbox();
            return View(messageList);
        }
        public ActionResult SendBox()
        {
            var messagelist = mm.GetListSendbox();
            return View(messagelist);   
        }
        public ActionResult GetInboxMessageDetails(int id)
        {
            var Values = mm.GetByID(id);
            return View(Values);
        }

        [HttpGet]
        public ActionResult NewMessage()
        {
            return View();
        }
        [HttpPost]
        public ActionResult NewMessage(Message p)
        {
            return View();
        }
    }
}