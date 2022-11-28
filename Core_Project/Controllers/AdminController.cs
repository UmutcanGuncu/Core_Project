using Microsoft.AspNetCore.Mvc;

namespace Core_Project.Controllers
{
    public class AdminController : Controller
    {
        public PartialViewResult PartialSidebar()
        {
            return PartialView();
        }
        public PartialViewResult FooterPartial()
        {
            return PartialView();
        }
        public PartialViewResult ScriptPartial() 
        {
            return PartialView();
        }
    }
}
