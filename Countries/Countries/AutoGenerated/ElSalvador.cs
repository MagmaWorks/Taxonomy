namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class ElSalvador : SingletonCountryBase<ElSalvador>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "El Salvador";
        private const string _countryCode = "SV";

        public ElSalvador() { }
    }
}

