namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class IsleOfMan : SingletonCountryBase<IsleOfMan>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Isle of Man";
        private const string _countryCode = "IM";

        public IsleOfMan() { }
    }
}

