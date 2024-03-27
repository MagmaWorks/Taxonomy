namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class Seychelles : SingletonCountryBase<Seychelles>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Seychelles";
        private const string _countryCode = "SC";

        public Seychelles() { }
    }
}

