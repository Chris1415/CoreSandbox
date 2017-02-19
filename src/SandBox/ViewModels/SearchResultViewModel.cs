using SandBox.Core.Models;
using System.Collections.Generic;

namespace SandBox.ViewModels
{
    /// <summary>
    /// Search Result View Model
    /// </summary>
    public class SearchResultViewModel
    {
        /// <summary>
        /// Specific Search Results
        /// </summary>
        public IEnumerable<IDummyContentModel> Results { get; set; }
    }
}
