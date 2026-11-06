public class Havale : OdemeYontemi, IBildirim
{

    public override double OdemeYap(double tutar)
    {
        if (tutar >= 1000)
        {
            return tutar - 20;
        }
        return tutar;
    }
    public void BildirimGonder(string mesaj)
    {
        Console.WriteLine(mesaj);
    }

}

