namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class Palau : SingletonCountryBase<Palau>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Palau";
        private const string _countryCode = "PW";

        public Palau() { }
    }
}

