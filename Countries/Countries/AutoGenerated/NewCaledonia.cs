namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class NewCaledonia : SingletonCountryBase<NewCaledonia>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "New Caledonia";
        private const string _countryCode = "NC";

        public NewCaledonia() { }
    }
}

