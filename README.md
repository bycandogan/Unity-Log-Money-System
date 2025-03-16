-- EN --

With these project codes, you can add a log infrastructure to your game in a simple way. There are 2 basic features in my site.

- Log System
- Money Management

1- Log System

In this structure, you can easily print a message with our code that uses the event structure in a file or in a certain situation at any point you want in the game.
Example Usage; LogSystem.Instance.TriggerTransactionLog(LogStatus.message, "Mission Complete", 0, 0);
Note: 0's here will take value in monetary transactions.
The money management system also automatically reports the transaction results to the log system and prints the transaction result as a log.

2- Money Management 

This structure manages the process of earning or spending money within a transaction in the game.
While earning money is done directly, the function returns "true" or "false" according to the result of whether the balance is sufficient by checking whether the amount desired to be spent in the money spending process is available.
At the same time, it generates a log message and outputs "-XX$" if the expenditure has been made. But if the available money is insufficient, it reports that the money is insufficient.
Example Usage; 

MoneyManager.Instance.AddMoney(20,10); // Making Money - Adding Money (the first value is the amount earned, the second value is the value earned extra as a tip.) (if the second value is "0", it will not appear.)

MoneyManager.Instance.SpendMoney(66); // Spending money (The structure that returns the result by checking and auditing and at the same time transferring the result to the log system.)

if(MoneyManager.Instance.SpendMoney(66)){

  // Spending money
  
}


The adjustments to be made in the code are specified.

-- TR --

Bu proje kodları ile oyunuza basit bir şekilde log alt yapısı ekleyebilirsiniz. Sitem içerisinde 2 temel özellik bulunmaktadır.

- Log Sistemi
- Para Yöbetimi

1- Log Sistemi

Bu yapıda oyun içerisinde istediğiniz her hangi bir noktada bir dosyada ya da belirli bir durumda event yapısını kullanan kodumuz ile kolayca bir mesaj yazdırabilirsiniz.

Örnek Kullanım; LogSystem.Instance.TriggerTransactionLog(LogStatus.message, "Mission Complete", 0, 0);

Not: Buradaki 0'lar parasal işlemlerde değer alacaktır.

Para yönetim sistemi de işlem sonuçlarını otomatik olarak log sisteme bildirerek işlem sonucunu log olarak yazdırmaktadır.

2- Para Yönetimi 

Bu yapı ise oyunda bir işlem içerisinde para kazanma ya da harcama işlemini yönetmektedir.
Para kazanma işlemi direkt yapılırken para harcama işleminde harcanmak istenen tutarın var olup olmadığı kontrol edilerek bakiyenin yeterli olup olmadığı sonucuna göre fonksiyon "true" ya da "false" cevabı döndürmektedir.
Aynı zamanda da Log mesajı oluşturarak harcama yapıldı ise "-XX$" çıktısı vermektedir. Ama mevcut para yetersiz ise paranın yetersiz olduğunu bildirmektedir.

Örnek Kullanım; 

MoneyManager.Instance.AddMoney(20,10); // Para Kazanma - Para Ekleme (ilk değer kazanılan tutar, ikinci değer bahşiş olarak ekstra kazanılan değerdir.)(ikinci değer "0" olur ise görünmeyecektir.)

MoneyManager.Instance.SpendMoney(66); // Para harcama (Kontrol ve denetim yapılarak sonuç döndüren ve aynı zamanda da sonucu log sisteme aktarak yapı.)


if(MoneyManager.Instance.SpendMoney(66)){

  // Para Harcama İşlem İlerlemesi
  
}


Kod içerisinde yapılması gereken ayarlamalar belirtilmiştir.
