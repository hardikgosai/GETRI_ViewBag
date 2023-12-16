using Microsoft.AspNetCore.Mvc;

namespace GETRI_ViewBag.Controllers
{
    public class CountriesController : Controller
    {
        public IActionResult Index()
        {
            List<string> lstCountries = new List<string>();
            lstCountries.Add("India");
            lstCountries.Add("USA");
            lstCountries.Add("UK");
            lstCountries.Add("Australia");
            lstCountries.Add("Canada");

            ViewBag.Countries = lstCountries;
            return View();
        }
    }
}
