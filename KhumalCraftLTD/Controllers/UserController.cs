using Microsoft.AspNetCore.Mvc;
using KhumalCraftLTD.Models;
namespace KhumalCraftLTD.Controllers
{
    public class UserController : Controller
    {

        public Table_1 usrtbl = new Table_1();



        [HttpPost]
        public ActionResult About(Table_1 Users)
        {
            var result = usrtbl.insert_User(Users);
            return RedirectToAction("Index", "Home");
        }
        [HttpGet]
        public ActionResult About()
        {

            return View(usrtbl);
        }

    }
}