namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class Kazakhstan : SingletonCountryBase<Kazakhstan>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Kazakhstan";
        private const string _countryCode = "KZ";

        public Kazakhstan() { }
    }
}

