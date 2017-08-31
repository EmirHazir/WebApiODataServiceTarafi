using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiOData.Models;

namespace WebApiOData.Controllers
{
    public class CategoryController : ApiController
    {

        public CategoryController()
        {
            //Bu tablo birbirine bağlı oldugu için sadece işlem yaptığım tablodan veri cekmeme olanak tanır
            db.Configuration.ProxyCreationEnabled = false;
        }
        private NORTHWNDEntities db = new NORTHWNDEntities();

        public void PostCategory(Category cat)
        {
            db.Categories.Add(cat);
            db.SaveChanges();
        }
    }
}
