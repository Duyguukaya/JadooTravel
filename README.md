# JadooTravel 🌍
**Modern, Yapay Zeka Destekli, Çok Dilli Seyahat Planlama Platformu – .NET 6 Üzerinde Geliştirilmiş**

---

## 📝 Proje Hakkında
JadooTravel, seyahat tutkunları için geliştirilmiş modern bir web uygulamasıdır. Bu proje sadece kullanıcı deneyimini zenginleştirmekle kalmaz; aynı zamanda **temiz, ölçeklenebilir ve bakımı kolay bir backend mimarisi** oluşturmayı hedefler.  

Projenin temel amacı, kullanıcılara **akıllı ve kişiselleştirilmiş seyahat önerileri** sunarken, backend kodunun **temiz, test edilebilir ve genişletilebilir** olmasını sağlamaktır.  

JadooTravel, aşağıdaki özellikleri bir araya getirir:  

- Modern **.NET 6 altyapısı**  
- **Modüler mimari** ve **katmanlı yapı**  
- **Yapay zeka entegrasyonu (OpenAI API)**  
- **Çoklu dil desteği (Localization)**  
- **Esnek ve doküman tabanlı veritabanı yönetimi (MongoDB)**  
- **Temiz veri akışı için DTO ve AutoMapper kullanımı**  

---

## ✨ Öne Çıkan Teknik Özellikler

### 🤖 Yapay Zeka Entegrasyonu
- OpenAI API kullanılarak **kullanıcıya özel seyahat önerileri** sağlanır.  
- Destinasyonlar hakkında zengin içerikler oluşturulur.  
- Doğal dil işleme (NLP) ve AI modelleri ile kullanıcı etkileşimi artırılır.  
- Örneğin, kullanıcı bir şehir veya tur aradığında, sistem geçmiş tercihler ve ilgi alanlarına göre akıllı öneriler sunar.  

### 🏗️ Modüler Mimari
- **View Components** kullanılarak projeyi bağımsız ve tekrar kullanılabilir modüllere ayırdık.  
- **MVC ve Repository Pattern** ile katmanlar arasında temiz ayrım sağlanmıştır.  
- Modüler yapı sayesinde yeni özellikler eklemek ve mevcut modülleri test etmek kolaydır.  
- Kodun okunabilirliği, bakımı ve genişletilebilirliği üst seviyeye taşınmıştır.  

### 🌐 Çoklu Dil Desteği (Localization)
- Uygulama **İngilizce, İspanyolca, Almanca, Türkçe ve Fransızca** dillerini destekler.  
- Kullanıcılar, uygulamayı kendi tercih ettikleri dilde deneyimleyebilir.  
- Global bir kullanıcı kitlesine hitap eder ve kullanıcı deneyimini artırır.  

### 📦 Temiz Veri Mimarisi
- Katmanlar arasında **DTO (Data Transfer Object)** deseni ile kontrollü veri akışı sağlanır.  
- **AutoMapper** ile entity ve DTO nesneleri arasındaki dönüşümler otomatikleştirilir.  
- Bu sayede kod tekrarından kaçınılır ve bakım kolaylığı sağlanır.  

### 📄 Esnek ve Güçlü Veritabanı
- **MongoDB**, doküman tabanlı, şemasız ve esnek bir veritabanı olarak tercih edilmiştir.  
- Karmaşık seyahat verilerini (turlar, destinasyonlar, rezervasyonlar, kullanıcı verileri) etkin şekilde yönetir.  
- Dinamik veri yapısı sayesinde uygulama yeni gereksinimlere kolayca uyum sağlar.  

---

## 🛠️ Kullanılan Teknolojiler ve Araçlar

| Bileşen | Teknoloji / Kütüphane |
|---------|----------------------|
| Backend | ASP.NET Core 6 |
| Veritabanı | MongoDB |
| API Entegrasyonu | OpenAI API |
| Mimari | MVC, Repository Pattern, DTO |
| Kütüphaneler | AutoMapper |
| Yapısal Özellikler | View Components, Localization |
| Dil Desteği | İngilizce, İspanyolca, Almanca, Türkçe, Fransızca |

---

## 📐 Mimari Kararlar
1. **Modülerlik:**  View Components ile uygulama bağımsız modüllere ayrıldı. Yeni özellik eklemek veya mevcut modülleri test etmek kolaylaştı.  
2. **DTO ve AutoMapper:** Veritabanı entity’leri ile API yanıtları arasında temiz ve güvenli veri akışı sağlandı.  
3. **MongoDB:** Esnek, doküman tabanlı yapısı ile karmaşık verileri yönetmek için ideal.  
4. **AI Entegrasyonu:** OpenAI API, öneri sistemi ve içerik üretimi için kullanıldı. Heavy computation sunucu tarafında yapılmadan AI kullanımı sağlandı.  
5. **Localization:** Global kullanıcılar için çoklu dil desteği eklendi.  

---

## 📸 Ekran Görüntüleri (Screenshots)
Aşağıdaki ekran görüntüleri, uygulamanın farklı sayfalarını ve özelliklerini göstermektedir.  
### Anasayfa
<img width="1894" height="821" alt="Ekran görüntüsü 2025-10-07 142509" src="https://github.com/user-attachments/assets/e0ae1e32-c924-4a97-b268-34c797246feb" />
<img width="1897" height="819" alt="Ekran görüntüsü 2025-10-07 142602" src="https://github.com/user-attachments/assets/8fd572e7-1628-4baa-a59e-75dedb872821" />
<img width="1893" height="820" alt="Ekran görüntüsü 2025-10-07 142550" src="https://github.com/user-attachments/assets/aaed193f-c6e4-45df-915a-cf44a3bde6d6" />
<img width="1895" height="822" alt="Ekran görüntüsü 2025-10-07 142538" src="https://github.com/user-attachments/assets/783fb85c-cc3e-40b7-96ce-d189f21a1977" />
<img width="1891" height="816" alt="Ekran görüntüsü 2025-10-07 142524" src="https://github.com/user-attachments/assets/fa186fa8-8616-4b48-9cca-7de1563db707" />
<img width="1895" height="822" alt="Ekran görüntüsü 2025-10-07 142637" src="https://github.com/user-attachments/assets/3362e330-9732-4f26-aa53-f84076b7983c" />
<img width="1898" height="819" alt="Ekran görüntüsü 2025-10-07 142618" src="https://github.com/user-attachments/assets/54ede355-b8de-4a27-b254-845eb92fec7b" />
<img width="1889" height="829" alt="Ekran görüntüsü 2025-10-07 142651" src="https://github.com/user-attachments/assets/44809248-ca83-4380-a9b6-d6f6ceafa72b" />
<img width="1893" height="817" alt="Ekran görüntüsü 2025-10-07 142701" src="https://github.com/user-attachments/assets/b198494f-cb5e-4dc2-aae4-bba03be8dbd7" />
<img width="1898" height="819" alt="Ekran görüntüsü 2025-10-07 142719" src="https://github.com/user-attachments/assets/a288e517-2541-46e5-bacb-51fd1faf204a" />
<img width="1897" height="822" alt="Ekran görüntüsü 2025-10-07 142750" src="https://github.com/user-attachments/assets/bea181a4-2736-45aa-8641-a6d328c5174b" />
<img width="1894" height="819" alt="Ekran görüntüsü 2025-10-07 142759" src="https://github.com/user-attachments/assets/c54d48c4-847b-464e-bcfe-b5a8fbebff70" />

### Admin Sayfası
<img width="1894" height="828" alt="Ekran görüntüsü 2025-10-07 142816" src="https://github.com/user-attachments/assets/539d866a-e70f-4eb8-8493-a21e1312282d" />
<img width="1894" height="820" alt="Ekran görüntüsü 2025-10-07 142846" src="https://github.com/user-attachments/assets/0010bb7e-e27f-40fc-aace-a589558b4982" />
<img width="1892" height="826" alt="Ekran görüntüsü 2025-10-07 142857" src="https://github.com/user-attachments/assets/fbfe69fe-c548-4be0-9a8e-6cad9605f6ef" />
<img width="1896" height="829" alt="Ekran görüntüsü 2025-10-07 142910" src="https://github.com/user-attachments/assets/640ce0c3-0154-41c6-8dea-78f8359be961" />
<img width="1911" height="821" alt="Ekran görüntüsü 2025-10-07 142924" src="https://github.com/user-attachments/assets/bb1fcdbe-af21-45ef-9d00-f5b9642a43f8" />
<img width="1890" height="822" alt="Ekran görüntüsü 2025-10-07 142933" src="https://github.com/user-attachments/assets/6fe25d3e-5b91-4172-bcb2-581ba8d3bc6d" />
<img width="1919" height="819" alt="Ekran görüntüsü 2025-10-07 142941" src="https://github.com/user-attachments/assets/8b32dc10-39a8-4d4a-9c09-5d8b5df63c96" />
<img width="1919" height="823" alt="Ekran görüntüsü 2025-10-07 143136" src="https://github.com/user-attachments/assets/d63f9f54-1bc5-4626-a98d-34646787c23f" />


### MongoDb
<img width="1445" height="892" alt="Ekran görüntüsü 2025-10-06 200252" src="https://github.com/user-attachments/assets/f9f5aca9-4800-4e09-a505-15a12b9550f9" />
<img width="1441" height="910" alt="Ekran görüntüsü 2025-10-06 200257" src="https://github.com/user-attachments/assets/027a1c5b-1427-47a9-ba36-ab54c7dfb389" />

