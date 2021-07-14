using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlmostEmpty3_1StarterCode.Controllers
{
    public class HomeController : Controller
    {
        #region NOTES
        // IActionResult is an interface that is used to swap different components quickly and efficiently.
        #endregion
        /// <summary>
        /// Interface for Index content.
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            // ViewBag.Title = "Course";
            ViewData["Title"] = "Course Title";
            return View(); // returns associated data.
        }

        /// <summary>
        /// Interface for About content.
        /// </summary>
        /// <returns></returns>
        public IActionResult About()
        {
            //ViewBag.Title = "Description";
            //ViewData["Title"] = "Course Description"; Added on About page.
            return View(); 
        }

        /// <summary>
        /// Interface for Book content.
        /// </summary>
        /// <returns></returns>
        public IActionResult Book()
        {
            return View();
        }
    }
}
