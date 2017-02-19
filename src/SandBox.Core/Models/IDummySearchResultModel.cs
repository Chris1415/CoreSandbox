using System.Collections.Generic;

namespace SandBox.Core.Models
{
    /// <summary>
    /// Interface of the Dummy Search Result Model
    /// </summary>
    public interface IDummySearchResultModel
    {
        //Actual Search Results
        IEnumerable<IDummyContentModel> SearchResults { get; set; }

        /// <summary>
        /// Total Number of Results
        /// </summary>
        int TotalNumberOfResults { get; set; }

        /// <summary>
        /// The Current Paging Model
        /// </summary>
        IPagingModel Paging { get; set; }
    }
}
