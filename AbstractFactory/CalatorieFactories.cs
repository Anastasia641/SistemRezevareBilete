namespace FactoryWebApp.Models.AbstractFactory;

using FactoryWebApp.Models.Domain;
using FactoryWebApp.Models.Produse;

public class CalatorieStandardFactory : ICalatorieFactory
{
    public TipBilet CreeazaBilet(Pasager pasager, Zbor zbor)
        => new BiletStandard(pasager, zbor);

    public IServiciuExtra CreeazaServiciu()
        => new ServiciuStandard();
}

public class CalatorieBusinessFactory : ICalatorieFactory
{
    public TipBilet CreeazaBilet(Pasager pasager, Zbor zbor)
        => new BiletBusiness(pasager, zbor);

    public IServiciuExtra CreeazaServiciu()
        => new ServiciuBusiness();
}