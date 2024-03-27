namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class Togo : SingletonCountryBase<Togo>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Togo";
        private const string _countryCode = "TG";

        public Togo() { }
    }
}

