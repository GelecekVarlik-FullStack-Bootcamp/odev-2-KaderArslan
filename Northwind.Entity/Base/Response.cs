using Northwind.Entity.IBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Entity.Base

{
    //Respons'um var ve IResponse'den kalıtım alır
    // kalıtım verme -> : IResponse
    // basit response döndürme, bir mesaj döndürülecekse
    public class Response : IResponse
    {
        //public string Message { get; set; } üye property denir.
        //public string Message Silersek üye değişken denir.
        //{ get; set; } bu şekilde kapsüllemeye yol açıyoruz. Bunlar olmasa kapsülleme yapamayız.
        //{ get; set; } kapsülleme için artık zeminimiz olmuş oluyor.

        public string Message { get; set; } //response mesaj döndürür yani kayıt başarılı

        public int StatusCode { get; set; } //Durum kodu

        public object Data { get; set; } // Data her şey olabilir
    }

    // -- Otomatik yapılıyor. verilen değere göre hangisinin çalışacağını sistem kendisi belirliyor --


    //Generic Response olacak, Çünkü 2 tane IResponse var
    //Ama bu Response'ta generic olacak
    // komplike response döndürme, 1 data listesi, personel listesi
    public class Response<T> : IResponse<T>
    {
        public string Message { get; set; }

        public int StatusCode { get; set; }

        //ve Data'da generic olacak, Mesela 1 personel personel listesi, Ya da sadece 5 sayısı hepsini kapsar.
        public T Data { get; set; }
    }
}
