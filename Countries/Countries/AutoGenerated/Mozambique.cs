namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class Mozambique : SingletonCountryBase<Mozambique>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Mozambique";
        private const string _countryCode = "MZ";

        public Mozambique() { }
    }
}

