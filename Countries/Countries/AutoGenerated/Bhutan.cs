namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class Bhutan : SingletonCountryBase<Bhutan>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Bhutan";
        private const string _countryCode = "BT";

        public Bhutan() { }
    }
}

