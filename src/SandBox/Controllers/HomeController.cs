using Microsoft.AspNetCore.Mvc;

namespace SandBox.Controllers
{
    /// <summary>
    /// Home Controller
    /// </summary>
    public class HomeController : Controller
    {
        /// <summary>
        /// Index
        /// </summary>
        /// <returns>Index.cshtml</returns>
        public IActionResult Index()
        {
            return View();
        }   

        /// <summary>
        /// Error
        /// </summary>
        /// <returns>Error.cshtml</returns>
        public IActionResult Error()
        {
            return View();
        }
    }
}
