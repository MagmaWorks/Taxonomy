namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class Tokelau : SingletonCountryBase<Tokelau>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Tokelau";
        private const string _countryCode = "TK";

        public Tokelau() { }
    }
}

