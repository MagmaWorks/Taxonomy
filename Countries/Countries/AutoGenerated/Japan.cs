namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class Japan : SingletonCountryBase<Japan>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Japan";
        private const string _countryCode = "JP";

        public Japan() { }
    }
}

