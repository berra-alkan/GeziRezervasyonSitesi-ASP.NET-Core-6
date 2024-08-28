using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje1.ViewComponents.Comment
{
    public class _CommentList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View(); 
        }
    }
}
