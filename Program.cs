using System;

namespace hata_yonetimi
{
    class Program
    {
        static void Main(string[] args)
        {
            //try //Hata alması muhtemel ve kontorl etmek istediğimiz kod bloğu girilir.
            //{
            //  Console.WriteLine("Bir sayı giriniz:");
            //  int sayi = Convert.ToInt32(Console.ReadLine());
            //  Console.WriteLine("Girmiş olduğunuz sayı: " + sayi);
            //}
            //catch(Exception ex) // Hatayı yakaladığınızda ne yapmak istediğinizi yazıyorsunuz.
            //{
            //    Console.WriteLine("Hata: " + ex.Message.ToString());
            //}
            //finally //Opsiyonel, zorunlu değil.
            //{
            //    Console.WriteLine("İşlem Tamamlandı.");
            //}

            try 
            {
                //int a=int.Parse(null);
                //int a=int.Parse("test");
                int a=int.Parse("-200000000000");
            }
            catch(ArgumentNullException ex)
            {
                Console.WriteLine("Boş değer girdiniz");
                Console.WriteLine(ex);
            }
            catch(FormatException ex)
            {
                Console.WriteLine("Veri tipi uygun değil");
                Console.WriteLine(ex);
            }
            catch(OverflowException ex)
            {
                Console.WriteLine("Çok küçük veya çok büyük bir değer girdiniz");
                Console.WriteLine(ex);
            }
            finally
            {
                Console.WriteLine("İşlem başarıyla gerçekleşti");
            }
        }
    }
}
