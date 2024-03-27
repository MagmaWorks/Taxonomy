namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class Argentina : SingletonCountryBase<Argentina>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Argentina";
        private const string _countryCode = "AR";

        public Argentina() { }
    }
}

