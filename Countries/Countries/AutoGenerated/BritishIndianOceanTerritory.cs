namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class BritishIndianOceanTerritory : SingletonCountryBase<BritishIndianOceanTerritory>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "British Indian Ocean Territory";
        private const string _countryCode = "IO";

        public BritishIndianOceanTerritory() { }
    }
}

