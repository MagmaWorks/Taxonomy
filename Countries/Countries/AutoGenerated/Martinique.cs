namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class Martinique : SingletonCountryBase<Martinique>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Martinique";
        private const string _countryCode = "MQ";

        public Martinique() { }
    }
}

