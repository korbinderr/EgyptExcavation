using Intex00.Areas.Identity.Data;
using Intex00.Models;
using Intex00.Models.MummyViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Intex00.Controllers
{
    public class HomeController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ILogger<HomeController> _logger;
        private MummiesContext context;

        public HomeController(UserManager<ApplicationUser> userManager, ILogger<HomeController> logger, MummiesContext temp)
        {
            _userManager = userManager;
            _logger = logger;
            context = temp;
        }


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Burials(string headdirection, string haircolor, string textilecolor, string textilefunction, string textilestructure, string sex, string ageatdeath, string depth, int pageNum = 1)
        {

            int pageSize = 10;

            var x = new MummyViewModel
            {
                burials = context.Burialall7
                .Where(m => (m.Headdirection == headdirection || headdirection == null) && (m.Haircolor == haircolor || haircolor == null) && (m.Value == textilecolor || textilecolor == null)
                && (m.Value4 == textilestructure || textilestructure == null) && (m.Sex == sex || sex == null) && (m.Ageatdeath == ageatdeath || ageatdeath == null)
                && (m.Depth == depth || depth == null) && (m.Value5 == textilefunction || textilefunction == null))

                .Skip((pageNum - 1) * pageSize)
                .Take(pageSize),

                PageInfo = new PageInfo
                {
                    TotalNumMummies = (haircolor == null
                    ? context.Burialall7.Count()
                    : context.Burialall7.Where(m => (m.Headdirection == headdirection || headdirection == null) && (m.Haircolor == haircolor || haircolor == null) && (m.Value == textilecolor || textilecolor == null)
                && (m.Value4 == textilestructure || textilestructure == null) && (m.Sex == sex || sex == null) && (m.Ageatdeath == ageatdeath || ageatdeath == null)
                && (m.Depth == depth || depth == null) && (m.Value5 == textilefunction || textilefunction == null)).Count()),
                    MummiesPerPage = pageSize,
                    CurrentPage = pageNum
                }
            };
            return View(x);
        }

        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Title = "Add";
            return View("Creating");
        }

        [HttpPost]
        public IActionResult Add(Burialall7 ba)
        {
            

            context.Add(ba);
            context.SaveChanges();

            return Redirect("Burials");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Title = "Edit";

            var mummy = context.Burialall7.Single(x => x.Keyid == id);

            return View("Creating", mummy);
        }

        [HttpPost]
        public IActionResult Edit(Burialall7 ba)
        {
            if (ModelState.IsValid)
            {
                context.Update(ba);//Adds info from the form
                context.SaveChanges();//Saves the info to the database.
                return RedirectToAction("Burials");
            }
            else
            {
                return View("Burials");
            }

        }

        public IActionResult Delete(int id)
        {
            var mummy = context.Burialall7.Single(x => x.Keyid == id);
            return View(mummy);
        }

        [HttpPost]
        public IActionResult Delete(Burialall7 ba)
        {
            context.Burialall7.Remove(ba);
            context.SaveChanges();

            return RedirectToAction("Burials");
        }

        public IActionResult ExtendedBurial(int id)
        {
            var mummy = context.Burialall7.Single(x => x.Keyid == id);
            return View(mummy);
        }

        public IActionResult Supervised()
        {
            return View();
        }

        public IActionResult Unsupervised()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
