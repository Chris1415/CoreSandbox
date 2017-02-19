using SandBox.Core.Repositories;
using SandBox.Core.Repositories.Implementations;
using SandBox.Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace SandBox.Controllers.Search.Base
{
    /// <summary>
    /// BAse Search Controller
    /// </summary>
    public class BaseSearchController : Controller
    {
        #region Properties
        /// <summary>
        /// reference to the Dummy Content Repo
        /// </summary>
        protected IDummyContentRepository DummyRepo = new DummyContentRepository(Labels.MaxNumberOfElements, Labels.ElementsPerPage);

        #endregion

        /// <summary>
        /// Dummy Query
        /// </summary>
        /// <param name="sp">search paramter</param>
        /// <returns>dummy results</returns>
        protected IDummySearchResultModel ExecuteDummyQuery(ISearchParameter sp)
        {
            return DummyRepo.GetDummyResults(sp, Labels.NumberOfWantedResults);
        }

        /// <summary>
        /// Static Labels
        /// </summary>
        public static class Labels
        {
            /// <summary>
            /// Number of Results which are wanted
            /// </summary>
            public const int NumberOfWantedResults = 120;

            /// <summary>
            /// Elements per Page
            /// </summary>
            public const int ElementsPerPage = 4;

            /// <summary>
            /// Max Number of Elements
            /// </summary>
            public const int MaxNumberOfElements = 1000;
        }
    }
}
