namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class Montserrat : SingletonCountryBase<Montserrat>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Montserrat";
        private const string _countryCode = "MS";

        public Montserrat() { }
    }
}

