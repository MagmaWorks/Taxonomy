namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class SanMarino : SingletonCountryBase<SanMarino>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "San Marino";
        private const string _countryCode = "SM";

        public SanMarino() { }
    }
}

