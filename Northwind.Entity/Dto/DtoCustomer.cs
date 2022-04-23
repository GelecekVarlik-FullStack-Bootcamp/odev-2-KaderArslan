using Northwind.Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Entity.Dto
{

    //DtoCustomer'ın DtoBase'dan kalıtım almasını isteyeceğiz

    // OOP ta sonrada classı değiştirmek olmadığından kalıtım verilmesi gerekiyor
    //referansımızı vermiş oluyoruz
    //DtoCustomer bunu başka bir yerde kullanacağımız için public yaptık
    //o yüzden mecburen DtoBase'ide public yapmalıyız
    public class DtoCustomer : DtoBase
    {
        //Yapıcı metod ismi ile aynıdır.
        //erişim tipi public olmalı, default internaldır.
        public DtoCustomer()
        {
        }

        public string CustomerId { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string ContactTitle { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
 
    }
}
