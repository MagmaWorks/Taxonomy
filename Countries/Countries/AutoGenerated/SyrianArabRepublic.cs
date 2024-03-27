namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class SyrianArabRepublic : SingletonCountryBase<SyrianArabRepublic>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Syrian Arab Republic";
        private const string _countryCode = "SY";

        public SyrianArabRepublic() { }
    }
}

