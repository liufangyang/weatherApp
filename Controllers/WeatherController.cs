using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WeatherForcastApp.Models;

namespace WeatherForcastApp.Controllers
{
    public class WeatherController : Controller
    {
        // GET: Weather
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetWeatherForcastByCityAndState(string city , string state)
        {
            Weather wea = new Weather();
            return Json(wea.GetWeatherForcastByCityAndState(city , state), JsonRequestBehavior.AllowGet);
        }
        public JsonResult GetWeatherForcastDefault()
        {
            Weather wea = new Weather();
            return Json(wea.GetWeatherForcastDefault(), JsonRequestBehavior.AllowGet);
        }
    }
}