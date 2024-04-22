
using NetQuestionProject;
using System.Xml.Linq;

//Question 1
//Sınırsız sayıda “int” tipinde parametre alabilen "Show" adında bir metod yazmanız
//gerektiğini varsayalım. Metod imzasını nasıl tanımlarsınız?

//Answer:
Question1 question1 = new Question1();
int[] list = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
question1.Show(list);


//Question 2
//IList<T> , ICollection<T> ve IEnumerable<T> interfacelerini implemente eden özel
//bir generic koleksiyon oluşturun

//Answer:
Question2<int> myCollection = new Question2<int>();

//added
myCollection.Add(10);
myCollection.Add(20);
myCollection.Add(30);

//remove item
myCollection.Remove(20);

//clear all item
myCollection.Clear();

foreach (int item in myCollection)
{
    Console.WriteLine(item);
}


//Question3
//“Name” adında bir özelliği olan bir Person sınıfı oluşturun. Herhangi bir kişinin adının
//değişip değişmediğini kontrol eden ve sonrasında ismine yeni değer atayan bir event
//yaratın ve çağırın.  bunu yazar mısın

//Answer:
Person person = new Person();
person.Name = "İlyas";

// Subscribe to the NameChanged event
person.NameChanged += (sender, e) =>
{
    Console.WriteLine($"Name changed from {e.OldName} to {e.NewName}");
};

// Change the name
person.Name = "Melike";


//Question 4
//Bir dosyada büyük miktarda veri tutmanız gerekiyor. Hangi serializer’ı tercih edersiniz?
//Neden?

//Answer
//Büyük miktarda veri saklamak için tercih ettiğimiz serializer formatı, öncelikle veri türümüze ve uygulamanızın gereksinimlerine bağlı olacaktır. Genellikle, Binary serileştirme büyük miktarda veri saklamak için en etkili olanıdır, çünkü daha küçük dosya boyutları sağlar ve işleme hızı genellikle daha iyidir.
//Ancak, okunabilirlik veya verinin yapısal olarak tutulması gibi özel gereksinimlerimiz varsa, JSON veya XML gibi metin tabanlı formatlar tercih edilebilir.


//Question 5
//Aşağıdaki döngülerden hangisi daha hızlıdır? Neden?
//a) For
//b) Do
//c) Parallel.for
//d) foreach

//Answer:
//Genel olarak, hız açısından en etkili olan seçenek, iş yükümüzün paralelleştirilmesine uygun olduğunda Parallel.For döngüsü olabilir.
//Ancak, dikkatli bir şekilde kullanılmalı ve çoklu iş parçacığı kullanımının potansiyel maliyetleri göz önünde bulundurulmalıdır.
//Diğer durumlarda, basit For veya foreach döngüleri genellikle yeterlidir ve daha az karmaşıklıkla daha iyi bir okunabilirlik sunar.


//Question 6
//www.google.com’un html kodunu konsol ekranına yazdıran bir uygulama geliştirin.
//Disposable Pattern’i kullanarak yönetilmeyen kaynakların bellekten atılmasını sağlayın.

//Answer:
string url = "https://www.google.com";
using (var htmlDownloader = new HtmlDownloader(url))
{
    string htmlContent = await htmlDownloader.DownloadHtmlAsync();
    if (htmlContent != null)
    {
        Console.WriteLine(htmlContent);
    }
    else
    {
        Console.WriteLine("Failed to download HTML.");
    }
}