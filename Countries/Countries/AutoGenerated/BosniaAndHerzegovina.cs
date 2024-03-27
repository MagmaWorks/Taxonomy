namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class BosniaAndHerzegovina : SingletonCountryBase<BosniaAndHerzegovina>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Bosnia and Herzegovina";
        private const string _countryCode = "BA";

        public BosniaAndHerzegovina() { }
    }
}

