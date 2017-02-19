using System;
using System.Collections.Generic;

namespace SandBox.Core.Models
{
    /// <summary>
    /// Interface of Paging Model
    /// </summary>
    public interface IPagingModel
    {
        /// <summary>
        /// Previous Link
        /// </summary>
        IPageElement Previous { get; set; }

        /// <summary>
        /// All Paging Elements
        /// </summary>
        IEnumerable<IPageElement> Elements { get; set; }

        /// <summary>
        /// Next Link
        /// </summary>
        IPageElement Next { get; set; }
    }
}
