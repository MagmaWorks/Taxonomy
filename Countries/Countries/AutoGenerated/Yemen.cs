namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class Yemen : SingletonCountryBase<Yemen>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Yemen";
        private const string _countryCode = "YE";

        public Yemen() { }
    }
}

