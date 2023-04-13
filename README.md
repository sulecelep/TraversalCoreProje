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
<img src="https://user-images.githubusercontent.com/120751470/231780072-f5d60701-0555-4267-bbe4-adf7cf4a471b.png" width="450">

![Resim1](https://user-images.githubusercontent.com/120751470/231780072-f5d60701-0555-4267-bbe4-adf7cf4a471b.png)
![Resim2](https://user-images.githubusercontent.com/120751470/231780177-cdcbf275-dd70-4832-ba7d-6024afaf701b.png)
![Resim3](https://user-images.githubusercontent.com/120751470/231780235-ca9a0430-5b5b-4384-a6df-0cd94d8c2a2e.png)
![Resim4](https://user-images.githubusercontent.com/120751470/231780239-27b8c672-5e95-4fea-9bb6-91e8a8be0d2c.png)
![Resim23](https://user-images.githubusercontent.com/120751470/231780394-bcc4eada-bd60-451c-ba2d-07b8a7fdf9a9.png)
![Resim22](https://user-images.githubusercontent.com/120751470/231780443-b5431e77-c442-477e-a025-0dc8beac0ef2.png)
![Resim15](https://user-images.githubusercontent.com/120751470/231780513-ecda647c-54cc-4fcc-b169-407b910812f0.png)
![Resim24](https://user-images.githubusercontent.com/120751470/231780581-9b1927f4-9e4a-4099-b1da-1d7c8dd67e01.png)
![Resim17](https://user-images.githubusercontent.com/120751470/231780636-52cf44b3-4e3c-441c-a165-af3e81c29c19.png)
![Resim16](https://user-images.githubusercontent.com/120751470/231780682-eb135fe0-3d72-4507-b734-1d6141a74c05.png)
![Resim11](https://user-images.githubusercontent.com/120751470/231780779-77aaedb0-ca64-4bec-bf69-42ad1ec7f35b.png)
![Resim12](https://user-images.githubusercontent.com/120751470/231780786-07e81c18-4fac-4817-bdd3-9d9558bddb43.png)
![Resim13](https://user-images.githubusercontent.com/120751470/231780791-c2f1b6ef-8c40-44c0-b97f-25f2c4ec7f6e.png)
![Resim14](https://user-images.githubusercontent.com/120751470/231780796-7e69ca49-f061-4edb-bd29-cca02fe0e4da.png)
![Resim16](https://user-images.githubusercontent.com/120751470/231780799-6b4ea90f-10d9-4266-99a4-bf59cedf4e63.png)
![Resim5](https://user-images.githubusercontent.com/120751470/231780898-0ee64ffd-8026-42cd-8b14-1adf1ff7593f.png)
![Resim6](https://user-images.githubusercontent.com/120751470/231780903-b540f70f-c87e-44ad-9551-6f36e1c05c2b.png)
![Resim7](https://user-images.githubusercontent.com/120751470/231780904-fb4053ef-d5fc-40d1-92c6-536c0342b71b.png)
![Resim8](https://user-images.githubusercontent.com/120751470/231780909-d35dacef-1e68-44a6-8dd6-536e560da692.png)
![Resim9](https://user-images.githubusercontent.com/120751470/231780979-85edb55e-1bd8-4b16-b295-6c31bc6c1c4c.png)
![Resim10](https://user-images.githubusercontent.com/120751470/231780986-8761ce93-0c6b-4248-b743-7e7e0e1ef304.png)
![Resim5](https://user-images.githubusercontent.com/120751470/231780991-49981a5c-5081-4bee-a086-cfd654e217c8.png)
![Resim6](https://user-images.githubusercontent.com/120751470/231780995-35e45ae6-982d-4217-8659-4baabfa26b5a.png)
![Resim7](https://user-images.githubusercontent.com/120751470/231780997-950709a2-300f-407b-9075-e3e5e8bba302.png)
![Resim8](https://user-images.githubusercontent.com/120751470/231780999-f4f89f24-ca5e-4d09-8ba4-850a41b8c0d2.png)
![Resim18](https://user-images.githubusercontent.com/120751470/231781098-e5e5f35b-257f-4ee9-a859-29480934e5e0.png)
![Resim19](https://user-images.githubusercontent.com/120751470/231781102-9b7875d0-e16c-41c2-9c6a-7723b4e389a7.png)
![Resim20](https://user-images.githubusercontent.com/120751470/231781104-349dd297-539a-4ad5-9eaf-178484b99a66.png)
![Resim21](https://user-images.githubusercontent.com/120751470/231781107-aa361e53-4657-4529-8aa8-fe82c2b07c55.png)
