namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class Andorra : SingletonCountryBase<Andorra>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Andorra";
        private const string _countryCode = "AD";

        public Andorra() { }
    }
}

