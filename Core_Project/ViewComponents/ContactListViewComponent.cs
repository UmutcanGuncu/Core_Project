using BusinnesLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Linq.Expressions;

namespace Core_Project.ViewComponents
{
    public class ContactListViewComponent:ViewComponent
    {
        ContactManager contactManager = new ContactManager(new EfContactDal());
        public IViewComponentResult Invoke()
        {
            var values =contactManager.TGetListAll();
            return View(values);
        }
    }
}
