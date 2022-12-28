using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using M3gogo.BLL;
using M3gogo.DBLayer;
using M3gogo.Models;

namespace M3gogo.Controllers
{
    public class MatchController : Controller
    {
        // GET: Match
        public ActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public ActionResult PassDate() // display view UI form to enter club details get method
        {

            return View();
        }

        [HttpPost]
        public ActionResult PassDate(availableMatchesToAttend availableMatchesToAttend1) // post method to get called automatically after user clicks submit button to submit form to db with club model data
        {

            if (!ModelState.IsValid)
            {
                return View();
            }
            //DateTime pass = DateTime.Parse(availableMatchesToAttend1);
            int res = DateTime.Compare(availableMatchesToAttend1.start_time, DateTime.Now);

            if (res > 0)
            {
                return RedirectToAction("Viewupcomingtest", new { CurrentDate = availableMatchesToAttend1.start_time });

            }
            else
            {
                return RedirectToAction("ViewAlreadyPlayed", new { CurrentDate = availableMatchesToAttend1.start_time });
            }


        }





        [HttpGet]

        public ActionResult Viewupcomingtest(DateTime CurrentDate) // post method to get called automatically after user clicks submit button to submit form to db with club model data
        {

            MatchBLL match = new MatchBLL();
            List<Match> list = match.Viewupcomingtest(CurrentDate).ToList();
           
            


            return View(list);
        }



        [HttpGet]

        public ActionResult ViewAlreadyPlayed(DateTime CurrentDate) // post method to get called automatically after user clicks submit button to submit form to db with club model data
        {

            MatchBLL match = new MatchBLL();
            List<Match> list = match.ViewAlreadyPlayed(CurrentDate).ToList();




            return View(list);
        }

    }
}
