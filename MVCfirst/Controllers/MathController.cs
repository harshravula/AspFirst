using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.Mvc;
using System.Xml.Schema;

namespace MVCfirst.Controllers
{
    public class MathController : Controller
    {
        // GET: Math
        public ActionResult Index()
        {
            return new ContentResult() { Content = "<h1>Hello<h1/>", ContentType = "text/html" };
        }
        public ActionResult sum(int x , int y)
        {
            int total = x + y;
            return new ContentResult()
            {
               
               Content="<h1>"+total+"<h1/>", 
               ContentType="text/html"
            };
        }
        public ActionResult dosum()
        {
            return View();
        }
    }
}