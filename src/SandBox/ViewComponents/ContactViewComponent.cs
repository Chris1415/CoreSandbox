using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SandBox.ViewComponents
{
    /// <summary>
    /// Contact View Component
    /// </summary>
    public class ContactViewComponent : ViewComponent
    {
        /// <summary>
        /// Invoke Async
        /// </summary>
        /// <returns>Default.cshtml</returns>
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View("~/Views/Components/Contact/Default.cshtml");
        }
    }
}
