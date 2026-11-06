public class KrediKarti:OdemeYontemi,IBildirim
{
    public double KomisyonHesapla(double tutar)
    {
        return tutar * 0.03;
    }

    public override double OdemeYap(double tutar)
    {
        double komisyon = KomisyonHesapla(tutar);
        return tutar+komisyon;
    }

    public void BilgiGoster()
    {
        Console.WriteLine($"Kredi kartı ile ödeme gerçekleştirildi.");
    }

    public void BildirimGonder(string mesaj)
    {
        Console.WriteLine(mesaj);

    }
}

