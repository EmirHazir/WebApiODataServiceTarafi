using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.OData.Query;
using WebApiOData.Models;

namespace WebApiOData.Controllers
{
    public class SupplierController : ApiController
    {

        public SupplierController()
        {
            db.Configuration.ProxyCreationEnabled = false;
        }

        private NORTHWNDEntities db = new NORTHWNDEntities();

        public List<Supplier> GetAllSuppliers()
        {
            List<Supplier> spList = db.Suppliers.ToList();
            return spList;

        }

        public Supplier GetAllSuppliers(int id)
        {
            var spplier = db.Suppliers;
            return spplier.FirstOrDefault(x => x.SupplierID == id);
        }

        public List<Supplier> GetAllSupplierOrderByName()
        {
            List<Supplier> splits = db.Suppliers.OrderBy(x => x.CompanyName).ToList();
            return splits;
        }
    }
}
