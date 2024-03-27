namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class UnitedKingdom : SingletonCountryBase<UnitedKingdom>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "United Kingdom";
        private const string _countryCode = "GB";

        public UnitedKingdom() { }
    }
}

