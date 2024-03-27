namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class BruneiDarussalam : SingletonCountryBase<BruneiDarussalam>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Brunei Darussalam";
        private const string _countryCode = "BN";

        public BruneiDarussalam() { }
    }
}

