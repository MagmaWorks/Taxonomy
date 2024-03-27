namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class CzechRepublic : SingletonCountryBase<CzechRepublic>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Czech Republic";
        private const string _countryCode = "CZ";

        public CzechRepublic() { }
    }
}

