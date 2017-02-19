using SandBox.Core.Models;
using System.Collections.Generic;

namespace SandBox.Core.Repositories
{
    /// <summary>
    /// Interface of Repository for Dummy Content
    /// </summary>
    public interface IDummyContentRepository
    {
        #region Properties

        /// <summary>
        /// Number of Results in the Repository
        /// </summary>
        int NumberOfEntriesInRepository { get; }

        /// <summary>
        /// Elements per Page
        /// </summary>
        int ElementsPerPage { get; }

        #endregion

        #region Interface

        /// <summary>
        /// Method to retriev all availbalbe Dummy Results
        /// </summary>
        /// <returns></returns>
        IDummySearchResultModel GetAllDummyResults(ISearchParameter searchParameter);

        /// <summary>
        /// Method to retriev a special Number of Dummy Results
        /// </summary>
        /// <param name="numberOfResults"></param>
        /// <returns></returns>
        IDummySearchResultModel GetDummyResults(ISearchParameter searchParameter, int numberOfResults = 20);

        #endregion
    }
}
