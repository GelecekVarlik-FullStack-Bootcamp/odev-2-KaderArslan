using Northwind.Entity.Dto;
using Northwind.Entity.IBase;
using Northwind.Entity.Models;
using Northwind.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Bll
{
    //bu artık hem genericmanagerin özelliğini kullanabilsin hem de 
    //CustomerManager'la iş yaparken
    //ortakları GenericManager 'ten alacak
    //özel metotsa CustomerManager'dan alacak
    public class CustomerManager : GenericManager<Customer, DtoCustomer>, ICustomerService
    {
        //Dal'la haberleşebilmesi için buraya sadece
        //ICustomerRepository'i dahil edeceğiz
        public IQueryable<DtoCustomer> GetTotalReport()
        {
            throw new NotImplementedException();
        }
    }
}
