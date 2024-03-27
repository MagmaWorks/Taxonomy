namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class SintMaartenDutchPart : SingletonCountryBase<SintMaartenDutchPart>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Sint Maarten (Dutch part)";
        private const string _countryCode = "SX";

        public SintMaartenDutchPart() { }
    }
}

