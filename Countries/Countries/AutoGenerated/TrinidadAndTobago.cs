namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class TrinidadAndTobago : SingletonCountryBase<TrinidadAndTobago>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Trinidad and Tobago";
        private const string _countryCode = "TT";

        public TrinidadAndTobago() { }
    }
}

