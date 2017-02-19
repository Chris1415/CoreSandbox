namespace SandBox.Core.Models
{
    /// <summary>
    /// Interface of Page Element
    /// </summary>
    public interface IPageElement
    {
        /// <summary>
        /// Link
        /// </summary>
        string Link { get; set; }

        /// <summary>
        /// Text
        /// </summary>
        string Text { get; set; }

        /// <summary>
        /// Flag to determine if the current Element is active
        /// </summary>
        bool IsActive { get; set; }

        /// <summary>
        /// Page Number
        /// </summary>
        string PageNumber { get; set; }
    }
}
