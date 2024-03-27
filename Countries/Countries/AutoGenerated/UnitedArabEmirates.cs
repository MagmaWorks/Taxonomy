namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class UnitedArabEmirates : SingletonCountryBase<UnitedArabEmirates>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "United Arab Emirates";
        private const string _countryCode = "AE";

        public UnitedArabEmirates() { }
    }
}

