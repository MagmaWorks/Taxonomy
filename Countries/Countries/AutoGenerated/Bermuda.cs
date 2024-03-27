namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class Bermuda : SingletonCountryBase<Bermuda>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Bermuda";
        private const string _countryCode = "BM";

        public Bermuda() { }
    }
}

