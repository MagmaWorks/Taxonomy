namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class EquatorialGuinea : SingletonCountryBase<EquatorialGuinea>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Equatorial Guinea";
        private const string _countryCode = "GQ";

        public EquatorialGuinea() { }
    }
}

