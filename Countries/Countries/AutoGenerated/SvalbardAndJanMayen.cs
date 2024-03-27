namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class SvalbardAndJanMayen : SingletonCountryBase<SvalbardAndJanMayen>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Svalbard and Jan Mayen";
        private const string _countryCode = "SJ";

        public SvalbardAndJanMayen() { }
    }
}

