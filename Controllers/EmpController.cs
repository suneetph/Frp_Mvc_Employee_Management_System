using Microsoft.AspNetCore.Mvc;
using Empprojectfp.Models;

namespace Empprojectfp.Controllers
{

    public class EmpController : Controller
    {
        private readonly ACE42023Context db;    

        public EmpController(ACE42023Context _db)
        {
            db = _db;           //dependicies injuction
        }
        

        public IActionResult ShowEmployee(){
            // ViewBag.username = HttpContext.Session.GetString("Username");
            // if(ViewBag.username != null){
                return View(db.SuneetEmployees.ToList());
            // }
            // else {
            //     return RedirectToAction("Login , Login");
            // }
        }

        public IActionResult Create(){
            return View();
        }

        
        [HttpPost]
        public IActionResult Create(SuneetEmployee emp)
        {
            db.SuneetEmployees.Add(emp);
            db.SaveChanges();
            return RedirectToAction("ShowEmployee");
        }
    }
}