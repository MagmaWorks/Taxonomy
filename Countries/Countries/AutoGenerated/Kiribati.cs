namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class Kiribati : SingletonCountryBase<Kiribati>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Kiribati";
        private const string _countryCode = "KI";

        public Kiribati() { }
    }
}

