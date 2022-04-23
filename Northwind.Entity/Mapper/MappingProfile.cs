using AutoMapper;
using Northwind.Entity.Dto;
using Northwind.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Entity.Mapper
{
    //Profile'dan kalıtım almalı bir Profile gibi çalışabilmesi için
    public class MappingProfile : Profile
    {
        //constracter oluşturacağız
        public MappingProfile()
        {
            //neyi neye dönüştereceğiz
            //customer modeldeki customer
            //neye dönüşsün dtocustomere
            CreateMap<Customer, DtoCustomer>().ReverseMap();//customer Dto'ya çalışır. Kaynak customer hedef Dto
            //Customer DtoCustomer'e dönüşebilir. Veritabanından bir müşteri geliyorsa.sen bunu bu modele dönüştür
            //ama ya tam tersi ise o yüzden Dto'nunda Customer'e dönüşmesi lazım
            //birbirine dönüşür

            CreateMap<AlphabeticalListOfProduct, DtoAlphabeticalListOfProduct>().ReverseMap();

            CreateMap<Category, DtoCategory>().ReverseMap();

            CreateMap<CategorySalesFor1997, DtoCategorySalesFor1997>().ReverseMap();

            CreateMap<CurrentProductList, DtoCurrentProductList>().ReverseMap();

            CreateMap<CustomerAndSuppliersByCity, DtoCustomerAndSuppliersByCity>().ReverseMap();

            CreateMap<CustomerCustomerDemo, DtoCustomerCustomerDemo>().ReverseMap();

            CreateMap<CustomerDemographic, DtoCustomerDemographic>().ReverseMap();

            CreateMap<Employee, DtoEmployee>().ReverseMap();

            CreateMap<EmployeeTerritory, DtoEmployeeTerritory>().ReverseMap();

            CreateMap<Invoice, DtoInvoice>().ReverseMap();

            CreateMap<Order, DtoOrder>().ReverseMap();

            CreateMap<OrderDetail, DtoOrderDetail>().ReverseMap();

            CreateMap<OrderDetailsExtended, DtoOrderDetailsExtended>().ReverseMap();

            CreateMap<OrdersQry, DtoOrdersQry>().ReverseMap();

            CreateMap<OrderSubtotal, DtoOrderSubtotal>().ReverseMap();

            CreateMap<Product, DtoProduct>().ReverseMap();

            CreateMap<ProductsAboveAveragePrice, DtoProductsAboveAveragePrice>().ReverseMap();

            CreateMap<ProductSalesFor1997, DtoProductSalesFor1997>().ReverseMap();

            CreateMap<ProductsByCategory, DtoProductsByCategory>().ReverseMap();

            CreateMap<QuarterlyOrder, DtoQuarterlyOrder>().ReverseMap();

            CreateMap<Region, DtoRegion>().ReverseMap();

            CreateMap<SalesByCategory, DtoSalesByCategory>().ReverseMap();

            CreateMap<SalesTotalsByAmount, DtoSalesTotalsByAmount>().ReverseMap();

            CreateMap<Shipper, DtoShipper>().ReverseMap();

            CreateMap<SummaryOfSalesByQuarter, DtoSummaryOfSalesByQuarter>().ReverseMap();

            CreateMap<SummaryOfSalesByYear, DtoSummaryOfSalesByYear>().ReverseMap();

            CreateMap<Supplier, DtoSupplier>().ReverseMap();

            CreateMap<Territory, DtoTerritory>().ReverseMap();

            CreateMap<User, DtoUser>().ReverseMap();

        }
    }
}
