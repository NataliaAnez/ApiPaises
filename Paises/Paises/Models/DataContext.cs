namespace Paises.Models
{
    using System.Data.Entity;
    public class DataContext : DbContext
    {
        public DataContext() : base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<Paises.Models.Country> Countries { get; set; }

        public System.Data.Entity.DbSet<Paises.Models.Currency> Currencies { get; set; }

        public System.Data.Entity.DbSet<Paises.Models.Language> Languages { get; set; }

        public System.Data.Entity.DbSet<Paises.Models.RegionalBloc> RegionalBlocs { get; set; }

        public System.Data.Entity.DbSet<Paises.Models.Translations> Translations { get; set; }
    }
}