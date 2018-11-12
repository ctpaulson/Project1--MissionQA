using Project1__MissionQA.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project1__MissionQA.Controllers
{
    public class MissionController : Controller
    {
        public List<string> listNames = new List<string> { "Brazil Florianópolis", "Puerto Rico San Juan", "New York New York" };

        public int MissionNumber { get; set; }

        // GET: Mission
        public ActionResult Missions()
        {
            ViewBag.missions = listNames;
            return View();
        }

        //POST: Mission
        [HttpPost]
        public ActionResult Missions(Mission mission)
        {
            if (mission.Name == "Brazil Florianópolis")
            {
                mission.President = "Ramilfo Silva";
                mission.Address = "Santa Catarina";
                mission.Language = "Portuguese";
                mission.Climate = "Sub-tropical";
                mission.DominantReligion = "Catholicism";
                mission.Symbol = "file-location-of-the-flag-image";

                //Displaying this is not working for some reason
                ViewBag.name = mission.Name;
                ViewBag.president = mission.President;
                
                return RedirectToAction("BR");
            }
            else if (mission.Name == "Puerto Rico San Juan")
            {
                return RedirectToAction("PR");
            }
            else
            {
                return RedirectToAction("NY");
            }
        }

        //GET: Brazil
        public ActionResult BR()
        {
            return View();
        }

        //GET: Puerto Rico
        public ActionResult PR()
        {
            return View();
        }

        //GET: New York
        public ActionResult NY()
        {
            return View();
        }
    }
}