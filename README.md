# Northwind Database ile N-Katmanlı Mimari

### Senaryo
---
Her bir Model'e ait;
* Interface katmanına Servis'lerin tanımlanması
* Bll (Business Logic Layer - İş Katmanı) katmanına Manager sınıflarının tanımlanması
* Dal (Data Access Layer) katmanına Interface'lerin (IRepository) ve Class'ların (Repository) tanımlanması.

### Amaç
---
* Interface katmanında bulunan Servis'lerin Manager'a Kalıtım verir.
* IRepository -> Repository yapısına kalıtım verir.
