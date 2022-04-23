using Northwind.Entity.Dto;
using Northwind.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Interface
{
    //Dependency injection'a dahil edeceğimizden public
    // : kalıtım alıyoruz demektir
    //T:Model:Customer
    public interface ICustomerService : IGenericService<Customer, DtoCustomer>
    {
        IQueryable<DtoCustomer> GetTotalReport();
    }
}
