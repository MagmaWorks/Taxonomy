namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class Latvia : SingletonCountryBase<Latvia>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Latvia";
        private const string _countryCode = "LV";

        public Latvia() { }
    }
}

