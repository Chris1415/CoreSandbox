namespace SandBox.Core.Models.Implementations
{
    /// <summary>
    /// Page Element
    /// </summary>
    public class PageElement : IPageElement
    {
        /// <summary>
        /// Link
        /// </summary>
        public string Link { get; set; }

        /// <summary>
        /// Text
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// Flag to determine if the current Element is active
        /// </summary>
        public bool IsActive { get; set; }

        /// <summary>
        /// Page Number
        /// </summary>
        public string PageNumber { get; set; }
    }
}
