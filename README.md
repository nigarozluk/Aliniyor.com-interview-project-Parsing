# Aliniyor.com-interview-project-Parsing

****The interview question is explained below in English and Turkish.****




***Mülakat Sorusu***

Uygulama C# ile yazılmalıdır.

Soru çözümünde eksik kalsanız dahi mutlaka bize iletin, bizim için yorumunuz önemlidir. Değerlendiriyor olacağız.
<br/>
<br/>
**Aşağıdaki gereksinimlere göre bir API tasarlayın ve proje haline getirin:**
<br/>
•	API, Veri kümelerinin tamamını okuyabilmeli ve aynı anda sadece biri üzerinden işlem yapmalıdır. (veri kümeleri ekte paylaşılmıştır “xml, csv”)
<br/>
•	API, Verileri JSON tipinde ekrana çıkarmalıdır.
<br/>
•	API, kayıtları bir veya daha fazla alana göre filtreleme ve sıralama becerisi sağlamalıdır (ör. Şehre göre filtreleme veya Bölgeye göre sıralama ASC / DESC)
<br/>
•	API 2 veri kümesini desteklemelidir: CSV ve XML. Ancak yeni veri kümeleri eklenmek istediğinde kolay bir geliştirme olanağı sağlanmalıdır (ör. JSON)
<br/>
<br/>
<br/>

*XML veri kümesi için veri biçimi özellikleri eklenmiştir (schema.xsd)*
<br/>
**Tavsiyeler:**
<br/>
•	Dosyalar çalışma esnasında upload edilmemelidir, projeye Solution Explorer üzerinden direkt olarak eklenebilir, upload edilmesine gerek yoktur.
<br/>
•	Veri kümeleri için Interface oluşturulmalı
<br/>
•	API dönüş tipi JSON olmalıdır
<br/>
•	Varsayılan olarak hangi veri kümesinden beslenmesi gerektiği web.config dosyasında bir konfigürasyon olarak tutulabilir
<br/>
•	Ek bir API metodu aracılığı ile varsayılan veri kümesini değiştirebilir. (ör. XML iken JSON ‘a çevirebilir. Bu sayede veri kaynağı JSON dosyası olacaktır.)
<br/>
<br/>

**Çözümünüz ile ilgili aşağıdaki soruları cevaplandırın:**
<br/>
•	API tasarımınız ile ilgili bilgi paylaşabilir misiniz ?
<br/>
•	Proje mimarisinda yaptığınız değişiklikler, design pattern’lar ile ilgili bilgi verebilir misiniz?
<br/>
•	Kullandığınız 3. Parti kütüphaneleri söyleyip işlevleri hakkında bilgi paylaşabilir misiniz?
<br/>


***Interview Question***
<br/>
*The application must be **built with C#***
<br/>

*Even if the solution is incomplete, please send it to us, your comment is important to us. We will be evaluating.*
<br/>
<br/>
**Design and project an API based on the following requirements:**
<br/>
• The API must be able to read all of the Datasets and operate on only one of them at a time. (datasets are shared in the appendix “xml, csv”)
<br/>
• API should output Data in JSON type.
<br/>
• The API should provide the ability to filter and sort records by one or more fields (eg Filter by City or Sort by Region ASC / DESC)
<br/>
• The API must support 2 datasets: CSV and XML. However, easy development should be provided when new datasets want to be added (ex. JSON)
<br/>
Added data format properties for XML dataset (schema.xsd)
<br/>
<br/>

**Advices:**
<br/>
• Files should not be uploaded while working, they can be directly added to the project via Solution Explorer, there is no need to upload them.
<br/>
• Interface should be created for data sets
<br/>
• API return type must be JSON
<br/>
• By default, which dataset should be fed can be kept as a configuration in the web.config file.
<br/>
• Can change the default dataset via an additional API method. (For example, it can convert from XML to JSON. Thus, the data source will be a JSON file.)
<br/>

**Answer the following questions about your solution:**
<br/>
• Can you share information about your API design?
<br/>
• Can you give information about the changes you have made in the project architecture and the design patterns?
<br/>
• Can you tell us the 3rd party libraries you use and share information about their functions?

