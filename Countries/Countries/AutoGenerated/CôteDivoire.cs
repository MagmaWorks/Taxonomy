namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class CôteDivoire : SingletonCountryBase<CôteDivoire>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Côte d'Ivoire";
        private const string _countryCode = "CI";

        public CôteDivoire() { }
    }
}

