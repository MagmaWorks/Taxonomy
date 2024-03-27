namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class Dominica : SingletonCountryBase<Dominica>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Dominica";
        private const string _countryCode = "DM";

        public Dominica() { }
    }
}

