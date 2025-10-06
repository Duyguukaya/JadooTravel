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
<img width="1894" height="834" alt="Ekran görüntüsü 2025-10-06 194508" src="https://github.com/user-attachments/assets/c69f3e49-f57f-407e-bdbc-0acedafd8b8f" />
<img width="1898" height="827" alt="Ekran görüntüsü 2025-10-06 194557" src="https://github.com/user-attachments/assets/a360436e-e04c-4ac6-a4e8-349b506f74cd" />
<img width="1895" height="827" alt="Ekran görüntüsü 2025-10-06 194544" src="https://github.com/user-attachments/assets/c31b6bcc-4fbf-485d-b8bf-a5f163b329da" />
<img width="1893" height="823" alt="Ekran görüntüsü 2025-10-06 194530" src="https://github.com/user-attachments/assets/4ca9cad6-17c4-4b7a-aa77-28030323d547" />
<img width="1887" height="821" alt="Ekran görüntüsü 2025-10-06 194519" src="https://github.com/user-attachments/assets/0a121aca-5e7d-477b-a698-bd726267f910" />
<img width="1890" height="822" alt="Ekran görüntüsü 2025-10-06 194610" src="https://github.com/user-attachments/assets/bc490aff-f84c-404f-bb21-0db031767788" />
<img width="1896" height="820" alt="Ekran görüntüsü 2025-10-06 194617" src="https://github.com/user-attachments/assets/1e278fad-2e27-4b62-870d-40225d8f2101" />
<img width="1894" height="823" alt="Ekran görüntüsü 2025-10-06 194624" src="https://github.com/user-attachments/assets/4ccc00ff-2cb9-4a1d-9a52-650476cef3d0" />
<img width="1898" height="820" alt="Ekran görüntüsü 2025-10-06 194632" src="https://github.com/user-attachments/assets/74961873-13ec-46b0-9224-46a1b4b38ad5" />
<img width="1892" height="821" alt="Ekran görüntüsü 2025-10-06 194639" src="https://github.com/user-attachments/assets/be23b101-0aa9-4bc5-919d-50fc2c5437b4" />
<img width="1895" height="824" alt="Ekran görüntüsü 2025-10-06 194647" src="https://github.com/user-attachments/assets/1397dae6-24b1-4555-aead-31178f765d32" />
<img width="1896" height="826" alt="Ekran görüntüsü 2025-10-06 194722" src="https://github.com/user-attachments/assets/33db45b5-32ef-4292-8b82-bb21f6bb9f3d" />
<img width="1890" height="818" alt="Ekran görüntüsü 2025-10-06 194731" src="https://github.com/user-attachments/assets/222f86d9-8274-45e0-a6fd-2216e6874d75" />
<img width="1892" height="820" alt="Ekran görüntüsü 2025-10-06 194741" src="https://github.com/user-attachments/assets/0d360d5b-c729-44b0-906f-3d337e1fd106" />


### Admin Sayfası
<img width="1896" height="828" alt="Ekran görüntüsü 2025-10-06 194754" src="https://github.com/user-attachments/assets/59d0a6a3-ab55-4edd-8fe9-c4f129a04d85" />
<img width="1892" height="825" alt="Ekran görüntüsü 2025-10-06 194803" src="https://github.com/user-attachments/assets/c3c422f1-2271-48a8-912c-c41d6bcf7f23" />
<img width="1897" height="826" alt="Ekran görüntüsü 2025-10-06 194826" src="https://github.com/user-attachments/assets/65e77eb1-5589-41b4-8864-c5c5651d3ecd" />
<img width="1896" height="826" alt="Ekran görüntüsü 2025-10-06 194811" src="https://github.com/user-attachments/assets/08ccc861-cda8-4d31-bd52-e61230f091e0" />
<img width="1899" height="832" alt="Ekran görüntüsü 2025-10-06 194838" src="https://github.com/user-attachments/assets/57d03184-2f32-4429-b744-4b6a58bce79e" />
<img width="1896" height="829" alt="Ekran görüntüsü 2025-10-06 194846" src="https://github.com/user-attachments/assets/34f1eb90-0cdb-4ef9-aaf7-8f9723734d52" />

### MongoDb
<img width="1445" height="892" alt="Ekran görüntüsü 2025-10-06 200252" src="https://github.com/user-attachments/assets/f9f5aca9-4800-4e09-a505-15a12b9550f9" />
<img width="1441" height="910" alt="Ekran görüntüsü 2025-10-06 200257" src="https://github.com/user-attachments/assets/027a1c5b-1427-47a9-ba36-ab54c7dfb389" />

