namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class Benin : SingletonCountryBase<Benin>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Benin";
        private const string _countryCode = "BJ";

        public Benin() { }
    }
}

