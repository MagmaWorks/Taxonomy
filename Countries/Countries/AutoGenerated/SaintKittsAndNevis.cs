namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class SaintKittsAndNevis : SingletonCountryBase<SaintKittsAndNevis>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Saint Kitts and Nevis";
        private const string _countryCode = "KN";

        public SaintKittsAndNevis() { }
    }
}

