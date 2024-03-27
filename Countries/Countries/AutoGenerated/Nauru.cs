namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class Nauru : SingletonCountryBase<Nauru>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Nauru";
        private const string _countryCode = "NR";

        public Nauru() { }
    }
}

