namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class FrenchSouthernTerritories : SingletonCountryBase<FrenchSouthernTerritories>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "French Southern Territories";
        private const string _countryCode = "TF";

        public FrenchSouthernTerritories() { }
    }
}

