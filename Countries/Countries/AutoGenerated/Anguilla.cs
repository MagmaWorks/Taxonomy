namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class Anguilla : SingletonCountryBase<Anguilla>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Anguilla";
        private const string _countryCode = "AI";

        public Anguilla() { }
    }
}

