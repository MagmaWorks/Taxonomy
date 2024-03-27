namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class Georgia : SingletonCountryBase<Georgia>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Georgia";
        private const string _countryCode = "GE";

        public Georgia() { }
    }
}

