using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.OData;
using System.Web.Http.OData.Query;
using WebApiOData.Models;

namespace WebApiOData.Controllers
{
    public class ProductController : ApiController
    {
        private NORTHWNDEntities db = new NORTHWNDEntities();

        //Queryable ile içine bu sorguyu sadece OrderBy yapabileceği iznini verdim
        [Queryable(AllowedQueryOptions =AllowedQueryOptions.OrderBy)]
        public IQueryable<Product> GetAllProducts()
        {
            db.Configuration.ProxyCreationEnabled = false;
            return db.Products;
        }
    }
}
