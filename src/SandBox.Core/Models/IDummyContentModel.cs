using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SandBox.Core.Models
{
    /// <summary>
    /// Interface for Model for Dummy content
    /// </summary>
    public interface IDummyContentModel
    {
        /// <summary>
        /// Title
        /// </summary>
        string Title { get; set; }

        /// <summary>
        /// Text
        /// </summary>
        string Text { get; set; }

        /// <summary>
        /// Link
        /// </summary>
        string Link { get; set; }

        /// <summary>
        /// Image
        /// </summary>
        string Image { get; set; }
    }
}
