using Microsoft.AspNetCore.Mvc;
using SandBox.Core.Models.Implementations;
using SandBox.Controllers.Search.Base;

namespace SandBox.Controllers.Search
{
    /// <summary>
    /// Search Page
    /// </summary>
    public class SearchPageQueryController : BaseSearchController
    {
        /// <summary>
        /// Index
        /// </summary>
        /// <returns>Index.cshtml</returns>
        public IActionResult Index(SearchParameter sp)
        {
            return View(this.ExecuteDummyQuery(sp));
        }
    }
}
