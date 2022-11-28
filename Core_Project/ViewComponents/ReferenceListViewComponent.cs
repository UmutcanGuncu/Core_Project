using BusinnesLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Project.ViewComponents
{
    public class ReferenceListViewComponent:ViewComponent
    {
        ReferenceManager referenceManager = new ReferenceManager(new EfReferenceDal());
        public IViewComponentResult Invoke()
        {
            var values = referenceManager.TGetListAll();
            return View(values);
        }
    }
}
