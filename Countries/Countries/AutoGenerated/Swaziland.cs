namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class Swaziland : SingletonCountryBase<Swaziland>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Swaziland";
        private const string _countryCode = "SZ";

        public Swaziland() { }
    }
}

