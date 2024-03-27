namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class Chile : SingletonCountryBase<Chile>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Chile";
        private const string _countryCode = "CL";

        public Chile() { }
    }
}

