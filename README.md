# Aliniyor.com-interview-project-Parsing

****The interview question is explained below in English and Turkish.****




***Mülakat Sorusu***

Uygulama C# ile yazılmalıdır.

Soru çözümünde eksik kalsanız dahi mutlaka bize iletin, bizim için yorumunuz önemlidir. Değerlendiriyor olacağız.

Aşağıdaki gereksinimlere göre bir API tasarlayın ve proje haline getirin:
•	API, Veri kümelerinin tamamını okuyabilmeli ve aynı anda sadece biri üzerinden işlem yapmalıdır. (veri kümeleri ekte paylaşılmıştır “xml, csv”)
•	API, Verileri JSON tipinde ekrana çıkarmalıdır. 
•	API, kayıtları bir veya daha fazla alana göre filtreleme ve sıralama becerisi sağlamalıdır (ör. Şehre göre filtreleme veya Bölgeye göre sıralama ASC / DESC)
•	API 2 veri kümesini desteklemelidir: CSV ve XML. Ancak yeni veri kümeleri eklenmek istediğinde kolay bir geliştirme olanağı sağlanmalıdır (ör. JSON)

XML veri kümesi için veri biçimi özellikleri eklenmiştir (schema.xsd)

Tavsiyeler:
•	Dosyalar çalışma esnasında upload edilmemelidir, projeye Solution Explorer üzerinden direkt olarak eklenebilir, upload edilmesine gerek yoktur.
•	Veri kümeleri için Interface oluşturulmalı
•	API dönüş tipi JSON olmalıdır
•	Varsayılan olarak hangi veri kümesinden beslenmesi gerektiği web.config dosyasında bir konfigürasyon olarak tutulabilir
•	Ek bir API metodu aracılığı ile varsayılan veri kümesini değiştirebilir. (ör. XML iken JSON ‘a çevirebilir. Bu sayede veri kaynağı JSON dosyası olacaktır.)

Çözümünüz ile ilgili aşağıdaki soruları cevaplandırın:
•	API tasarımınız ile ilgili bilgi paylaşabilir misiniz ?
•	Proje mimarisinda yaptığınız değişiklikler, design pattern’lar ile ilgili bilgi verebilir misiniz?
•	Kullandığınız 3. Parti kütüphaneleri söyleyip işlevleri hakkında bilgi paylaşabilir misiniz?


***Interview Question***

The application must be built with C#.

Even if the solution is incomplete, please send it to us, your comment is important to us. We will be evaluating.

Design and project an API based on the following requirements:
• The API must be able to read all of the Datasets and operate on only one of them at a time. (datasets are shared in the appendix “xml, csv”)
• API should output Data in JSON type.
• The API should provide the ability to filter and sort records by one or more fields (eg Filter by City or Sort by Region ASC / DESC)
• The API must support 2 datasets: CSV and XML. However, easy development should be provided when new datasets want to be added (ex. JSON)

Added data format properties for XML dataset (schema.xsd)

Advices:
• Files should not be uploaded while working, they can be directly added to the project via Solution Explorer, there is no need to upload them.
• Interface should be created for data sets
• API return type must be JSON
• By default, which dataset should be fed can be kept as a configuration in the web.config file.
• Can change the default dataset via an additional API method. (For example, it can convert from XML to JSON. Thus, the data source will be a JSON file.)

Answer the following questions about your solution:
• Can you share information about your API design?
• Can you give information about the changes you have made in the project architecture and the design patterns?
• Can you tell us the 3rd party libraries you use and share information about their functions?

