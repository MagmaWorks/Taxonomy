namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class Fiji : SingletonCountryBase<Fiji>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Fiji";
        private const string _countryCode = "FJ";

        public Fiji() { }
    }
}

