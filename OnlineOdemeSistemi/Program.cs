KrediKarti krediKarti = new KrediKarti();
Havale havale = new Havale();



char secim;
string mesaj;

do
{
    Console.WriteLine("=====ÖDEME YÖNTEMİ=====");
    Console.Write("\nAlışveriş tutarını giriniz: ");
    double tutar = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("\nÖdeme Yöntemi:");
    Console.WriteLine("1-Kredi Kartı");
    Console.WriteLine("2-Havale");
    Console.Write("Seçiminiz: ");

    secim = Convert.ToChar(Console.ReadLine());

    Console.WriteLine("\n\n=====ÖDEME SONUCU=====\n");
    if (secim == '1')
    {
        Console.WriteLine("Ödeme Yöntemi: Kredi Kartı");
        Console.WriteLine($"Alışveriş Tutarı: {tutar} TL");
        Console.WriteLine($"Komisyon: {krediKarti.KomisyonHesapla(tutar)} TL");
        Console.WriteLine($"Ödenecek Tutar: {krediKarti.OdemeYap(tutar)} TL");
        mesaj = "Ödemeniz başarıyla tamamlandı.";
        Console.WriteLine($"Bildirim: {mesaj}");
    }

    if (secim == '2')
    {
        Console.WriteLine("Ödeme Yöntemi: Havale");
        Console.WriteLine($"Alışveriş Tutarı: {tutar} TL");
        Console.WriteLine($"Ödenecek Tutar: {havale.OdemeYap(tutar)} TL");
        mesaj = "Ödemeniz başarıyla tamamlandı.";
        Console.WriteLine($"Bildirim: {mesaj}");
    }

    Console.Write("\nYeni bir ödeme yapmak istiyor musunuz? (E/H) ");
    secim = Convert.ToChar(Console.ReadLine());

} while (secim == 'E');

Console.ReadKey();




