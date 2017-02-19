using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace SandBox.ViewComponents
{
    /// <summary>
    /// Stage Slider
    /// </summary>
    public class StageSliderViewComponent : ViewComponent
    {
        /// <summary>
        /// Invoke Async
        /// </summary>
        /// <returns>Default.cshtml</returns>
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View("~/Views/Components/StageSlider/Default.cshtml");
        }
    }
}
