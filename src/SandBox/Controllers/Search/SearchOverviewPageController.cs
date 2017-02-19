using Microsoft.AspNetCore.Mvc;

namespace SandBox.Controllers.Search
{
    /// <summary>
    /// Search Overview page
    /// </summary>
    public class SearchOverviewPageController : Controller
    {
        /// <summary>
        /// Index
        /// </summary>
        /// <returns>Index View</returns>
        public IActionResult Index()
        {
            return View();
        }
    }
}
