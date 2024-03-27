namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class SaintBarthélemy : SingletonCountryBase<SaintBarthélemy>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Saint Barthélemy";
        private const string _countryCode = "BL";

        public SaintBarthélemy() { }
    }
}

