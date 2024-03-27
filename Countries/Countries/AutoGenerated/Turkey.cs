namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class Turkey : SingletonCountryBase<Turkey>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Turkey";
        private const string _countryCode = "TR";

        public Turkey() { }
    }
}

