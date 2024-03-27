namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class Pitcairn : SingletonCountryBase<Pitcairn>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Pitcairn";
        private const string _countryCode = "PN";

        public Pitcairn() { }
    }
}

