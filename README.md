# Northwind Database ile N-Katmanlı Mimari

## Senaryo
Microsoft'un sağladığı Northwind Database ile .Net5 ile N Katmanlı Mimari Yapısını kurmak ve Jwt Token ile Token oluşturmak.

### Her bir Model'e ait;
1. N-Katmanlı Mimaride Entity katmanında bulunan Model klasörü altındaki class'ların Dto class'larını oluşturmak ve MappingProfile yapısını eklemek,
1. Interface katmanına Servis'lerin tanımlanması,
1. Dal (Data Access Layer) katmanına Interface'lerin (IRepository) ve Class'ların (Repository) tanımlanması,
1. Bll (Business Logic Layer - İş Katmanı) katmanına Manager sınıflarının tanımlanması,
1. WebApi katmanında Controller yapılarını oluşturmak.
---

**Northwind Database:** Sql'e yeni başlayanların ya da kendilerini geliştirmek için sorgu örneklerini detaylı bir şekilde kullanabilecekleri Microsoft'un sağlamış olduğu ücretsiz bir database örneğidir.

---

## Uygulama Görselleri
### User Login
![UserLogin](https://github.com/GelecekVarlik-FullStack-Bootcamp/odev-2-KaderArslan/blob/main/screenshots/user.png)
---
### Category
![Category](https://github.com/GelecekVarlik-FullStack-Bootcamp/odev-2-KaderArslan/blob/main/screenshots/category.png)
---
### Customer
![Customer](https://github.com/GelecekVarlik-FullStack-Bootcamp/odev-2-KaderArslan/blob/main/screenshots/customer.png)
---
### Employee
![Employee](https://github.com/GelecekVarlik-FullStack-Bootcamp/odev-2-KaderArslan/blob/main/screenshots/employee.png)
---
### Invoice
![Invoice](https://github.com/GelecekVarlik-FullStack-Bootcamp/odev-2-KaderArslan/blob/main/screenshots/invoice.png)
---
### Order
![Order](https://github.com/GelecekVarlik-FullStack-Bootcamp/odev-2-KaderArslan/blob/main/screenshots/order.png)
---
### Product
![Product](https://github.com/GelecekVarlik-FullStack-Bootcamp/odev-2-KaderArslan/blob/main/screenshots/product.png)
---
### Region
![Region](https://github.com/GelecekVarlik-FullStack-Bootcamp/odev-2-KaderArslan/blob/main/screenshots/region.png)
---
### Supplier
![Supplier](https://github.com/GelecekVarlik-FullStack-Bootcamp/odev-2-KaderArslan/blob/main/screenshots/supplier.png)
---
### Territory
![Territory](https://github.com/GelecekVarlik-FullStack-Bootcamp/odev-2-KaderArslan/blob/main/screenshots/territory.png)
