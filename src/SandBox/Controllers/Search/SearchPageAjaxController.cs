using Microsoft.AspNetCore.Mvc;
using SandBox.Controllers.Search.Base;
using SandBox.Core.Models.Implementations;

namespace SandBox.Controllers.Search
{
    /// <summary>
    /// Search Page
    /// </summary>
    public class SearchPageAjaxController : BaseSearchController
    {
        /// <summary>
        /// Index
        /// </summary>
        /// <returns>Index.cshtml</returns>
        public IActionResult Index()
        {
            // History.pushState Handling //
            SearchParameter savedParams = new SearchParameter()
            {
                Page = 1
            };

            return View(this.ExecuteDummyQuery(savedParams));
        }

        /// <summary>
        /// Method to get Search Results based on the given paramter
        /// </summary>
        /// <param name="searchParameter">search paramter</param>
        /// <returns>Search Result View</returns>
        public IActionResult GetSearchResults(SearchParameter searchParameter)
        {
            return PartialView("Partials/SearchResults", this.ExecuteDummyQuery(searchParameter));
        }
    }
}
