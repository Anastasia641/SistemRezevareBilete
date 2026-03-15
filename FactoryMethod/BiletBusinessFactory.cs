namespace FactoryWebApp.Models.FactoryMethod;

using FactoryWebApp.Models.Domain;
using FactoryWebApp.Models.Produse;

public class BiletBusinessFactory : BiletFactory
{
    public override TipBilet CreeazaBilet(Pasager pasager, Zbor zbor)
        => new BiletBusiness(pasager, zbor);
}