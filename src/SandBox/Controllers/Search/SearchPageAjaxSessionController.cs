using Microsoft.AspNetCore.Mvc;
using SandBox.Controllers.Search.Base;
using Microsoft.AspNetCore.Http;
using SandBox.Core.Models.Implementations;
using Newtonsoft.Json;

namespace SandBox.Controllers.Search
{
    /// <summary>
    /// Search Page
    /// </summary>
    public class SearchPageAjaxSessionController : BaseSearchController
    {
        /// <summary>
        /// Index
        /// </summary>
        /// <returns>Index.cshtml</returns>
        public IActionResult Index()
        {
            SearchParameter savedParams = null;

            // Session Handling //
            // Disable Caching so Browser Back does not use a cached version of the page
            HttpContext.Response.Headers.Add("Cache-Control", "no-cache, no-store, must-revalidate"); // HTTP 1.1.
            HttpContext.Response.Headers.Add("Pragma", "no-cache"); // HTTP 1.0.
            HttpContext.Response.Headers.Add("Expires", "0"); // Proxies.

            string serializedParams = HttpContext.Session.GetString("SavedParams");
            if (serializedParams != null)
            {
                savedParams = JsonConvert.DeserializeObject<SearchParameter>(serializedParams);
            }

            if (savedParams == null)
            {
                savedParams = new SearchParameter()
                {
                    Page = 1
                };
            }

            return View(this.ExecuteDummyQuery(savedParams));
        }

        /// <summary>
        /// Method to get Search Results based on the given paramter
        /// </summary>
        /// <param name="searchParameter">search paramter</param>
        /// <returns>Search Result View</returns>
        public IActionResult GetSearchResults(SearchParameter searchParameter)
        {
            string serializedParams = JsonConvert.SerializeObject(searchParameter);
            HttpContext.Session.SetString("SavedParams", serializedParams);
            return PartialView("Partials/SearchResults", this.ExecuteDummyQuery(searchParameter));
        }
    }
}
