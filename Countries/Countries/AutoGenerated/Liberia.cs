namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class Liberia : SingletonCountryBase<Liberia>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Liberia";
        private const string _countryCode = "LR";

        public Liberia() { }
    }
}

