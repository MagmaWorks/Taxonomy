namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class WesternSahara : SingletonCountryBase<WesternSahara>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Western Sahara";
        private const string _countryCode = "EH";

        public WesternSahara() { }
    }
}

