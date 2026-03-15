namespace FactoryWebApp.Models.Bilete
{
    public interface IBilet
    {
        string NumePasager { get; }
        string Destinatie { get; }
        double CalculeazaPret();
        string AfiseazaDetalii();
    }
}