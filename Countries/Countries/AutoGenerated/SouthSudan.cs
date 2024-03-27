namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class SouthSudan : SingletonCountryBase<SouthSudan>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "South Sudan";
        private const string _countryCode = "SS";

        public SouthSudan() { }
    }
}

