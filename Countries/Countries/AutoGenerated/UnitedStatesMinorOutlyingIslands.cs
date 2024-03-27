namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class UnitedStatesMinorOutlyingIslands : SingletonCountryBase<UnitedStatesMinorOutlyingIslands>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "United States Minor Outlying Islands";
        private const string _countryCode = "UM";

        public UnitedStatesMinorOutlyingIslands() { }
    }
}

