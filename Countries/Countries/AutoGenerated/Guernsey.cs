namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class Guernsey : SingletonCountryBase<Guernsey>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Guernsey";
        private const string _countryCode = "GG";

        public Guernsey() { }
    }
}

