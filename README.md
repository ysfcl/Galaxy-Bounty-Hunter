# Unity Haftalık Ödev  - BLM0364 Oyun Programlama

Bu proje, Unity'de temel sahne ve nesne yönetimini öğrenmek amacıyla hazırlanmıştır.  
Ödev kapsamında aşağıdaki işlemler yapılmıştır:

## İçerik
- Yeni Unity projesi oluşturuldu (3D Template)
- Yeni sahne eklendi, varsayılan sahne silindi
- Sahneye bir `Cube` nesnesi eklendi (`Player` olarak adlandırıldı)
- Nesneye materyal eklendi (renk değişimi)
- Nesneye `player_sc.cs` script'i eklendi
- `Start()` fonksiyonu ile nesne konumu bir kez değiştirildi
- `Update()` fonksiyonu ile sürekli hareket sağlandı
- `Time.deltaTime` ile zaman normalizasyonu yapıldı
- `speed` değişkeni tanımlandı (public ve private farkı açıklandı)
- `Input.GetAxis("Horizontal")` ile yatay hareket, `Input.GetAxis("Vertical")` ile dikey hareket input alma yoluyla klavyeden sağlandı
- Laser Prefab oluşturuldu
- Laser Prefab için materyal oluşturuldu ve prefabe tanımlandı
- Ateş etme fonksiyonu yazıldı
- Harita dışarısına çıkan prefabler silindi ve bellekten tasarruf edildi
  
## Nasıl Çalıştırılır
1. Unity Hub üzerinden projeyi açın.
2. `Scenes` klasöründen `GameScene` dosyasını açın.
3. Hafta 1 için `player_sc` dosyasını, Hafta 2 için `mermi_sc`ve `Ödev2` dosyalarını inceleyiniz. Hafta 2'de yazılı hareket fonksiyonu bulunmamaktadır
4. Oyun moduna geçerek karakterin hareketini gözlemleyin.

## Proje Sahibi
- **Ad Soyad:** Yusuf Çil
- **Ders:** BLM-0364 Oyun Programlama

