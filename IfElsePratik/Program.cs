
using System.ComponentModel.Design;

Console.Write("Lütfen bir sayı giriniz : "); 
int sayı = Convert.ToInt32(Console.ReadLine()); //Kullanıcıdan aldığımız sayıyı okuyoruz.
if (sayı > 10)   //Girilen sayının 10'dan büyük, küçük ya da eşit olup olmadığını kontrol eden if, else if ve else kullanımı.
{ Console.WriteLine("Girilen sayı 10'dan büyüktür."); }
else if (sayı < 10) 
{ Console.WriteLine("Girilen sayı 10'dan küçüktür."); }
else 
{ Console.WriteLine("Girilen sayı 10'a eşittir."); }

if (sayı % 2 == 0) //Girilen sayının tek ya da çift olup olmadığını kontrol eden if ve else kullanımı.
{ Console.WriteLine("Girilen sayı çifttir."); }
else
{ Console.WriteLine("Girilen sayı tektir."); }

