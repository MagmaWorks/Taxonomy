namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class SaintPierreAndMiquelon : SingletonCountryBase<SaintPierreAndMiquelon>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Saint Pierre and Miquelon";
        private const string _countryCode = "PM";

        public SaintPierreAndMiquelon() { }
    }
}

