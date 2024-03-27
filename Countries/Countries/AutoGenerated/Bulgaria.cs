namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class Bulgaria : SingletonCountryBase<Bulgaria>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Bulgaria";
        private const string _countryCode = "BG";

        public Bulgaria() { }
    }
}

