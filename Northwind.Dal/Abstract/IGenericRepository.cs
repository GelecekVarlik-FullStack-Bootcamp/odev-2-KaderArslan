using Northwind.Entity.IBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Dal.Abstract
{
    //Servisle (Interfacele) Abstract aynı değildir
    //Abstract T olarak çalışacak
    //Servise (Interface) TDto olarak çalışıyor
    //Servisin (Interface) anlamı arayüzden yani apiden Bll'e gelmek
    //Abstract'ın amacı ise Bll'den Dal'a gelmek
    //Abstract'tan Concrete kalıtım vereceğiz
    //Sonrada Bll ile Dal'ı bağlıcağız bağlarken Interfaceler üzerinden bağlayacağız
    //Api'den Bll'e de Interface üzerinden bağlanıyoruz new'leme class yöntemi ile gitmiyoruz
    public interface IGenericRepository<T> where T:IEntityBase
    {
        //Dal da hep T dir. DB'ye bağlanan kısım
        //Listeleme
        List<T> GetAll();

        //Filtreli Listeleme
        List<T> GetAll(Expression<Func<T, bool>> expression);

        //Getirme (Find bulma işlemi)
        T Find(int id);

        //Kaydetme (ekleme)
        T Add(T item);

        //Async Kaydetme
        Task<T> AddAsync(T item);

        //Güncelleme
        T Update(T item);

        //Silme
        bool Delete(int id);

        bool Delete(T item);
        //ilgili id ye ait nesneyi siler. ORM hep nesne siler


        //IQueryaple Listeleme
        IQueryable<T> GetIQueryable();
    }
}
