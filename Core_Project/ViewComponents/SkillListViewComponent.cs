using BusinnesLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Project.ViewComponents
{
    public class SkillListViewComponent:ViewComponent
    {
        SkillManager skillManager = new SkillManager(new EfSkillDal());
        
        public IViewComponentResult Invoke()
        {
            var values = skillManager.TGetListAll();
            return View(values);
        }
    }
}
