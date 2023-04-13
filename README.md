# TraversalCoreProje
 Traversal Projesi, gezi turlarının düzenlendiği, rehberlerin ve tur rotalarının olduğu bir ASP .NET Core MVC Projesidir. 
 ### Kamp Youtube Kanalı: https://www.youtube.com/playlist?list=PLKnjBHu2xXNMK5MBogdXmsXVi3K_eEZT5

## Proje Hakkında: 
Veri tabanı olarak SQL Server kullanılarak, BusinessLayer, DataAccessLayer, DTOLayer, EntityLayer, PresentationLayer, SignalRApiForSQL ve SingalRConsume katmanlarından oluşan N Tier Architecture mimarisi, ASP.Net Core 5.0 ve Entity Framework Core teknolojileri kullanılarak Codefirst yaklaşımı ile API'lerle desteklenmiş ve kodlanmıştır. Ayrıca MSSQL ve Postgre SQL veri tabanları da kullanılmıştır.

Bu proje, tatil rezervasyonu alanında faaliyet gösteren bir web sitesini temsil etmektedir. Sitede, çeşitli tatil seçeneklerinin listelendiği, kullanıcıların kişisel hesabına ve siteye ait bilgilere erişebildiği ve admin kullanıcısının da site içerisinde CRUD işlemleri gerçekleştirebildiği üç farklı tasarıma sahip bir projedir.

## Aşağıda, proje geliştirme aşamaları sıralı bir şekilde sunulmaktadır:

1. Katmanlar oluşturuldu ve projenin genel yapısı belirlendi.
2. Veritabanı işlemleri için Context sınıfı tanımlandı ve migration işlemi gerçekleştirildi.
3. DataAccesLayer ve BusinessLayer Generic Interface'leri kullanılarak veri erişimi yapıldı.
4. Repository Design Pattern yaklaşımı kullanılarak veritabanı işlemleri gerçekleştirildi.
5. Fluent Validation kütüphanesi kullanılarak giriş yapılan verilerin doğruluğu kontrol edildi.
6. Partial Async ve View Component yapıları kullanılarak performans artırımı sağlandı.
7. MSSQL veritabanı kullanılarak CRUD işlemleri yapıldı.
8. Yorumları ait olduğu rotaya göre listeleme ve yaptırma işlemleri gerçekleştirildi.
9. Identity kullanılarak kullanıcı girişi yapıldı ve kullanıcının profil bilgileri getirildi.
10. Login ve Register sayfaları oluşturuldu.
11. Custom Identity Validator işlemleri gerçekleştirildi.
12. Identity ile kullanıcı profil ve resim bilgisi güncellemesi yapıldı.
13. Giriş yapmış kullanıcıya ait aktif, onay bekleyen, geçmiş ve yeni rezervasyon sayfaları oluşturuldu.
14. Include metodu ve Ef bağımlılığının kaldırıldı.
15. Container dependencies ve startup yapıları refactoring edildi.
16. 404 not found sayfası oluşturuldu.
17. Hem dinamik hem de statik excel ve pdf raporları sayfaları oluşturuldu.
18. Mail gönderme işlemi yapıldı.
19. Ajax işlemleri yapıldı.
20. Data Transfer Object (DTO) katmanı oluşturuldu ve AutoMapper kullanılarak veri transferi işlemleri optimize edildi.
21. Api Projesi ana projede kullanıldı.
22. Rapid Api Booking üzerinden otel listesi çekildi.
23. CQRS Design Pattern kullanılarak veri işlemleri ayrıştırıldı.
34. MediatR kütüphanesi kullanılarak işlemler daha düzenli bir şekilde yapıldı.
35. Unit Of Work implementasyonu yapıldı ve veritabanı işlemleri daha yönetilebilir hale getirildi.
36. Api üzerinden ziyaretçi veri seti oluşturuldu.
37. CrossTab kullanılarak ziyaretçiler için pivot tablosu oluşturuldu.
38. SignalR kullanılarak grafikte anlık veri görüntüleme yapıldı.
39. Rol CRUD işlemleri gerçekleştirildi.
40. Çoklu dil desteği ve şifremi unuttum sayfaları ile kampı tamamladık.

## Proje Görselleri
