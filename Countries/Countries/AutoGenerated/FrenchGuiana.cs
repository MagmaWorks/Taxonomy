namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class FrenchGuiana : SingletonCountryBase<FrenchGuiana>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "French Guiana";
        private const string _countryCode = "GF";

        public FrenchGuiana() { }
    }
}

