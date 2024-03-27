namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class Botswana : SingletonCountryBase<Botswana>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Botswana";
        private const string _countryCode = "BW";

        public Botswana() { }
    }
}

