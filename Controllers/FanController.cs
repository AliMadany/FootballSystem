﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using M3gogo.BLL;
using M3gogo.Models;

namespace M3gogo.Controllers
{
    public class FanController : Controller
    {

        StadiumBLL FanBLL = new StadiumBLL();
        // GET: Fan
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        [ActionName("BlockFan")]
        public ActionResult BlockFan() // display view UI form to enter club details get method
        {

            return View();
        }


        [HttpPost]

        public ActionResult BlockFan(Fan bfan) // post method to get called automatically after user clicks submit button to submit form to db with club model data
        {
            FanBLL.BlockFan(bfan);

            return View(bfan);
        }
    }
}