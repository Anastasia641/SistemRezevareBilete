namespace FactoryWebApp.Models.AbstractFactory;

public class ServiciuStandard : IServiciuExtra
{
    public void Descriere()
    {
        Console.WriteLine("Serviciu STANDARD inclus pentru pasager.");
    }
}

public class ServiciuBusiness : IServiciuExtra
{
    public void Descriere()
    {
        Console.WriteLine("Serviciu BUSINESS inclus pentru pasager.");
    }
}
