using System.Collections.Generic;

namespace SandBox.Core.Models.Implementations
{
    /// <summary>
    /// Paging Model
    /// </summary>
    public class PagingModel : IPagingModel
    {
        /// <summary>
        /// Previous Link
        /// </summary>
        public IPageElement Previous { get; set; }

        /// <summary>
        /// All Paging Elements
        /// </summary>
        public IEnumerable<IPageElement> Elements { get; set; }

        /// <summary>
        /// Next Link
        /// </summary>
        public IPageElement Next { get; set; }
    }
}
