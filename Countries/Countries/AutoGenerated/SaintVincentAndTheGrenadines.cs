namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class SaintVincentAndTheGrenadines : SingletonCountryBase<SaintVincentAndTheGrenadines>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Saint Vincent and the Grenadines";
        private const string _countryCode = "VC";

        public SaintVincentAndTheGrenadines() { }
    }
}

