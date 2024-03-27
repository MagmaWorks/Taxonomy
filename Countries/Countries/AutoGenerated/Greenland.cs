namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class Greenland : SingletonCountryBase<Greenland>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Greenland";
        private const string _countryCode = "GL";

        public Greenland() { }
    }
}

