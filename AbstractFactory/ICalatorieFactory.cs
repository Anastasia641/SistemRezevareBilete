namespace FactoryWebApp.Models.AbstractFactory;

using FactoryWebApp.Models.Domain;
using FactoryWebApp.Models.Produse;

public interface ICalatorieFactory
{
    TipBilet CreeazaBilet(Pasager pasager, Zbor zbor);
    IServiciuExtra CreeazaServiciu();
}