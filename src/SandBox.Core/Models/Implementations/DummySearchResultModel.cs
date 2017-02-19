using System.Collections.Generic;

namespace SandBox.Core.Models.Implementations
{
    /// <summary>
    /// Dummy Search Result Model
    /// </summary>
    public class DummySearchResultModel : IDummySearchResultModel
    {
        //Actual Search Results
        public IEnumerable<IDummyContentModel> SearchResults { get; set; }

        /// <summary>
        /// Total Number of Results
        /// </summary>
        public int TotalNumberOfResults { get; set; }

        /// <summary>
        /// The Current Paging Model
        /// </summary>
        public IPagingModel Paging { get; set; }
    }
}
