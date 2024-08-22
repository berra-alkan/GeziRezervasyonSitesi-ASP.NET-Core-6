using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje1.ViewComponents.Default
{
    public class _SliderPartial: ViewComponent
    {
        public IViewComponentResult Invoke()
        { 
            return View(); 
        } 
    }
}
