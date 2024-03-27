namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class Morocco : SingletonCountryBase<Morocco>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Morocco";
        private const string _countryCode = "MA";

        public Morocco() { }
    }
}

