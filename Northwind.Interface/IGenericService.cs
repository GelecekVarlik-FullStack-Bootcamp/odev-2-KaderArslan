using Northwind.Entity.IBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Northwind.Interface
{
    //Generic yapıyoruz
    //T -> modeli ifade eder
    //TDto ise bizim Dto'muzu ifade eder, özel ifade değil, genel ifadeler bunlar
    //Mesela filtrelemede T, dönüş tipi TDto olur
    //kaydetme ise TDto veririz dönüş T olur o yüzden 2 ifadeyede ihtiyacımız var
    //where ile değişkenlerin tipini belirtiyoruz

    public interface IGenericService<T,TDto> where T:IEntityBase where TDto:IDtoBase
    {
        //her modeldeki olabilecek ortak işlemler bunlar ortak olanlar sadece burda olacak.
        //her metodta default olarak olması gereken işlemler.

        //Listeleme
        //sorgum var ve sürekli ekliyoruz
        //to list dediğimizde çalışır sorguyu özelleştiriyoruz
        //MVC geliştirseydik List<TDto> GetAll(); olabilirdi ama biz api geliştiriyoruz.
        IResponse<List<TDto>> GetAll();
        //Response iş katmanında Bll'de döner

        //Filtreli Listeleme
        //veritabanından getirdiğimiz için db modelini kullandık o yüzden T dedik, dinamik where sağlıyor
        //kendisi where yapısı oluşturuyor, where koymaya gerek yok
        IResponse<List<TDto>> GetAll(Expression<Func<T, bool>> expression);

        //Getirme (Find bulma işlemi)
        //nesne döndürür, 1 id'li customerı getir
        IResponse<TDto> Find(int id);

        //Kaydetme (ekleme)
        //Entity frameworkte kaydedersek kaydedilen nesneyi döner
        //TDto klavyeden geliyor arayüzden geliyor
        //bool saveChanges = true yapısı Unitofworks yapısı için şimdiden hazırlıyoruz, kendimiz yönetmek için
        IResponse<TDto> Add(TDto item, bool saveChanges = true);

        //Async Kaydetme #C doğası gereği senkron çalışır default olarak, yani işlemler birbirini bekler
        //çoklu işlem yaptırmak için async tasarlamak gerekir
        //ilgili işlem bitmeden diğer işlemlerin devam etmesidir, işlemlerin birbirini beklememesidir
        Task<IResponse<TDto>> AddAsync(TDto item, bool saveChanges = true);

        //Güncelleme
        IResponse<TDto> Update(TDto item, bool saveChanges = true);

        //Async Güncelleme
        Task<IResponse<TDto>> UpdateAsync(TDto item, bool saveChanges = true);

        //Silme
        IResponse<bool> DeleteById(int id, bool saveChanges = true);

        //Async Silme
        Task<IResponse<bool>> DeleteByIdAsync(int id, bool saveChanges = true);
        //saveChanges ben belirtmediğim sürece kaydetsin transaction onaylasın ama istediğim yerdede yönetimi bana versin
        //false dersek belleğe alır transacctionu onaylamaz taki biz true diyene kadar
        //bütünleşik işlemler var ise true yap

        //IQueryaple Listeleme diğer listelemeden farkı ne
        //eğer veritabanında bir sorgu çalıştıracaksak IQueryable listeleme ile
        //bellekte sorgu ise performans için
        IQueryable<TDto> GetIQueryable();
        //veri tabanında bir sorgu çalıştıracaksak Queryable olarak tasarlanır
        //Bellekte bir iş yapacaksak IEryable olarak tasarlanır
        //Bir sorgu var Kocaelide çalışan müşterileri çekeceğiz. Normalde 10 bin müşteri var. Bu IEryable olsun
        //Sistem veritabanına sorguyu gönderiyor 10 bin kişi belleğe geliyor, 10 bin kişi içerisinde kocaelide yaşayanları bulup sonuç döndürüyor
        //IErryable 10 bin kişiyi alıyor getiriyor ondan sonra bunların içinden kocaelidekileri buluyor Bellekte. IEryablede ise hepsini çeker çektikten sonra kocaelide olanları arar 
        //Beklenti ise veritabanından bana sadece kocaelidekileri getir diyorsak bunu sağlayan queryabledir. Sorguyu veritabanına atar sorgu sonucu sadece Queryablede döner

        //List ise ekliyoruz sürekli sorguyu özelleştirdiğimizde o zamanda to list diyoruz 


        //Insert, update, delete de asenkron yönetimi vardır
        //yani 1 tane silme yap transaction onayla ya da onu sil bunu sil ondan sonra onayla
        //performans için transaction yönetimi şart
    }


}
