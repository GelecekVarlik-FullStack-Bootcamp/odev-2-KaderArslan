using Microsoft.EntityFrameworkCore;
using Northwind.Dal.Abstract;
using Northwind.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Dal.Concrete.Entityframework.Repository
{
    public class CustomerRepository : GenericRepository<Customer>, ICustomerRepository
    {
        //base kalıtım aldığımız sınıfa argüman göndermek için kullanılır.
        public CustomerRepository(DbContext context) : base(context)
        {

        }

        //this ilgili Aynı sınıfta concactırdan consactıra veri göndermek için kullanılır
        public IQueryable<Customer> GetTotalReport()
        {
            return dbset.AsQueryable();
        }
    }
}
