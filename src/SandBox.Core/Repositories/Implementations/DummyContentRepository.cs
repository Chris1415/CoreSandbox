using SandBox.Core.Implementations.Models;
using SandBox.Core.Models;
using SandBox.Core.Models.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SandBox.Core.Repositories.Implementations
{
    /// <summary>
    /// Repository for Dummy Content
    /// </summary>
    public class DummyContentRepository : IDummyContentRepository
    {
        #region Properties

        /// <summary>
        /// Number of Results in the Repository
        /// </summary>
        public int NumberOfEntriesInRepository { get; }

        /// <summary>
        /// Elements per Page
        /// </summary>
        public int ElementsPerPage { get; }

        #endregion

        #region c'tor

        /// <summary>
        /// Default c'tor
        /// 10 Results as Default
        /// </summary>
        public DummyContentRepository()
        {
            this.NumberOfEntriesInRepository = 10;
            this.ElementsPerPage = 6;
        }

        /// <summary>
        /// c'tor with Parameter
        /// </summary>
        /// <param name="numberOfResultsInReposiotry">Number of results in Repository</param>
        /// <param name="ElementsPerPage">Elements per Page</param>
        public DummyContentRepository(int numberOfResultsInReposiotry, int elementsPerPage)
        {
            this.ElementsPerPage = elementsPerPage;
            this.NumberOfEntriesInRepository = numberOfResultsInReposiotry;
        }

        #endregion

        #region Interface

        /// <summary>
        /// Method to retriev all availbalbe Dummy Results
        /// </summary>
        /// <returns>All Results in Repository</returns>
        public IDummySearchResultModel GetAllDummyResults(ISearchParameter searchParameter)
        {
            return GetDummyResults(searchParameter, this.NumberOfEntriesInRepository);
        }

        /// <summary>
        /// Method to retriev a special Number of Dummy Results
        /// </summary>
        /// <param name="numberOfResults">number of results to retriev</param>
        /// <returns>Results in Reposiotry</returns>
        public IDummySearchResultModel GetDummyResults(ISearchParameter searchParamter, int numberOfResults = 20)
        {
            int totalNumberOfResults;
            if (numberOfResults <= 0)
            {
                return this.EmptySearchResultModel;
            }

            if (numberOfResults > this.NumberOfEntriesInRepository)
            {
                numberOfResults = this.NumberOfEntriesInRepository;
            }

            totalNumberOfResults = numberOfResults;
            IList<IDummyContentModel> results = new List<IDummyContentModel>();
            for (int i = 0; i < numberOfResults; i++)
            {
                results.Add(new DummyContentModel()
                {
                    Title = $"Title_{i}",
                    Text = $"Text_{i}",
                    Image = string.Empty,
                    Link = "http://www.google.de",
                });
            }

            results = results.Skip(ElementsPerPage * (searchParamter.Page - 1)).Take(ElementsPerPage).ToList();

            return new DummySearchResultModel()
            {
                SearchResults = results,
                TotalNumberOfResults = totalNumberOfResults,
                Paging = CreatePagingModel(searchParamter.Page, totalNumberOfResults, ElementsPerPage)
            };
        }

        #endregion

        #region Helper

        /// <summary>
        /// Helper to create the Paging Model
        /// </summary>
        /// <param name="currentPage">current Page</param>
        /// <param name="totalNumberOfResults">total number of results</param>
        /// <param name="elementsPerPage">elements per page</param>
        /// <returns></returns>
        private IPagingModel CreatePagingModel(int currentPage, int totalNumberOfResults, int elementsPerPage)
        {
            IList<IPageElement> elements = new List<IPageElement>();
            int start = currentPage <= Labels.Interval ? 0 : currentPage - Labels.Interval;
            int end = (int)Math.Ceiling((double)totalNumberOfResults / elementsPerPage);
            int indexEnd = currentPage >= end - Labels.Interval ? end : currentPage + Labels.Interval;

            for (int i = start; i < indexEnd; i++)
            {
                int index = i + 1;
                elements.Add(new PageElement()
                {
                    IsActive = index == currentPage,
                    Link = string.Empty,
                    PageNumber = index.ToString(),
                    Text = index.ToString()
                });
            }

            return new PagingModel()
            {
                Previous = currentPage > 1 
                ? new PageElement()
                {
                    IsActive = false,
                    Link = string.Empty,
                    Text = "&lt;",
                    PageNumber = (currentPage - 1).ToString()
                } 
                :
                null,
                Next = currentPage < (totalNumberOfResults / elementsPerPage) 
                ? new PageElement()
                {
                    IsActive = false,
                    Link = string.Empty,
                    Text = "&gt;",
                    PageNumber = (currentPage + 1).ToString()
                }
                : null,
                Elements = elements
            };
        }

        /// <summary>
        /// Helper to create an empty Search Result Model
        /// </summary>
        private IDummySearchResultModel EmptySearchResultModel => new DummySearchResultModel()
        {
            SearchResults = new List<IDummyContentModel>(),
            Paging = new PagingModel(),
            TotalNumberOfResults = 0
        };

        #endregion

        public static class Labels
        {
            public const int Interval = 4;
        }
    }
}
