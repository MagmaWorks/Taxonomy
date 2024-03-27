namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class UnitedStates : SingletonCountryBase<UnitedStates>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "United States";
        private const string _countryCode = "US";

        public UnitedStates() { }
    }
}

