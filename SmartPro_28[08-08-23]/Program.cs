using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPro_28_08_08_23_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Microsoft'un bize sumuş olduğu bazı hazır string methodları bulunmaktadır.
            //Bu string methodlar sayesinde bir takım işlemlerimizi kolaylaştırabiliriz
            //Bunlardan en sık kullanılanlarını örnekler halinde işleyelim

            string text = "Hi World!";

            //Lenght methodu
            //Bir string değerin karakter uzunluğunu alır
            //Geriye int tipinde değer verir.

            Console.WriteLine("Karakter uzunluğu: {0}",text.Length);

            //IndexOf Methodu
            //Bir string değerin içerisinde bir karakter veya kelime aramanızı sağlar.
            //Bulduğu ilk değer hangi index numarası ile başlıyor ise o index numarasını geri döndürür.
            //() içerisine metinsel veritipi eklenir.
            //Eğer sonuç bulunamadıysa -1 sonucunu getirir.

            Console.WriteLine("Baştan İndex No: {0}",text.IndexOf('l'));

            //LastIndexOf methodu
            //IndexOf ile aynı çalışır fakat taramaya sondan başlar.

            Console.WriteLine("Sondan İndex No: {0}", text.LastIndexOf('l'));

            //Contains() Methodu
            //Bir string değerin içerisinde bir karakter veya kelime aramınızı sağlar
            //Eğer bir sonuç bulunursa true, yok ise false verir.

            Console.WriteLine("Bulundu/Bulunamadı: {0}",text.Contains("Hi"));

            //Replace() Methodu
            //Bir string değer içerisinde bulunan karakter veya metni,
            //başka bir metin veya karakter ile değiştirmenizi sağlar
            //() içerisine sıra ile önce değişecek sonra da yazılacak karakter yazılır.

            Console.WriteLine("Metin/Karakter değiştir: {0}",text.Replace("World","Moon"));

            //ToUpper() Methodu
            //Karakterleri büyük har yapar.

            Console.WriteLine("Büyük harf: {0}",text.ToUpper());

            //ToLower() Methodu
            //Karakterleri küçük harf yapar.
            Console.WriteLine("Küçük harf: {0}", text.ToLower());

            //Trim Methodu
            //Değişkende ki metnin başında ve sonunda bulunan boşluk karakterlerini temizler.
            string textq = "                          Selam              ";
            Console.WriteLine("Temizle: {0} ",textq.Trim());

            //Split() Methodu
            //Bir string değeri belirli bir karakter ile bölüp 
            Console.WriteLine("\nDeğişken içindeki kelimeleri ayırma");
            string texts = "Araba Traktör Balyoz Kamyonet Yamaha_R25";
            var characters = texts.Split(new char[] { ' ' });
            foreach (var character in characters) 
            {
                Console.WriteLine(character);
            }

            Console.ReadKey();
        }
    }
}
