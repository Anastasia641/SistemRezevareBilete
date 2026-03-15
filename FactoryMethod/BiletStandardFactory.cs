namespace FactoryWebApp.Models.FactoryMethod;

using FactoryWebApp.Models.Domain;
using FactoryWebApp.Models.Produse;

public class BiletStandardFactory : BiletFactory
{
    public override TipBilet CreeazaBilet(Pasager pasager, Zbor zbor)
        => new BiletStandard(pasager, zbor);
}