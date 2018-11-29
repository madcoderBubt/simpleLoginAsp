using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LoginWeb.Models;

namespace LoginWeb.Controllers
{
    public class HomeController : Controller
    {
        string conString = @"Data Source=MAD-CODER\SQLEXPRESS;Initial Catalog=logDB;Integrated Security=True";
        

        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(LogModel lg)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            SqlCommand cmd = new SqlCommand("select count(*) from logTb where UserName = '"+lg.userName+"' and Password = '"+lg.password+"'",con);

            var output = int.Parse(cmd.ExecuteScalar().ToString());

            if (output == 1)
            {
                Session["UserName"] = lg.userName;
                return RedirectToAction("About");
            }
            else
                return RedirectToAction("Failed");
        }


        public ActionResult About()
        {

            return View();
        }

        public ActionResult Failed()
        {
            return View();
        }
    }
}