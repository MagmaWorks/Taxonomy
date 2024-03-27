namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class Macao : SingletonCountryBase<Macao>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Macao";
        private const string _countryCode = "MO";

        public Macao() { }
    }
}

