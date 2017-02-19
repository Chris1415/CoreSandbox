using SandBox.Core.Models;

namespace SandBox.Core.Implementations.Models
{
    /// <summary>
    /// Model for Dummy Content
    /// </summary>
    public class DummyContentModel : IDummyContentModel
    {
        /// <summary>
        /// Title
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Text
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// Link
        /// </summary>
        public string Link { get; set; }

        /// <summary>
        /// Image
        /// </summary>
        public string Image { get; set; }
    }
}
