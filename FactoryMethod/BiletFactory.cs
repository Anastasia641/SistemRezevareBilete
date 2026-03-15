namespace FactoryWebApp.Models.FactoryMethod;

using FactoryWebApp.Models.Domain;
using FactoryWebApp.Models.Produse;

// Factory abstract
public abstract class BiletFactory
{
    public abstract TipBilet CreeazaBilet(Pasager pasager, Zbor zbor);
}