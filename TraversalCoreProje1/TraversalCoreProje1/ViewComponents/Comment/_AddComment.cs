using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje1.ViewComponents.Comment
{
    public class _AddComment : ViewComponent
    {
        public IViewComponentResult Invoke()
        { 
            return View(); 
        }

    }
}
