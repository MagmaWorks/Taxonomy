namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class CapeVerde : SingletonCountryBase<CapeVerde>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Cape Verde";
        private const string _countryCode = "CV";

        public CapeVerde() { }
    }
}

