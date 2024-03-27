namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class FaroeIslands : SingletonCountryBase<FaroeIslands>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Faroe Islands";
        private const string _countryCode = "FO";

        public FaroeIslands() { }
    }
}

