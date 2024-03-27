namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class Kyrgyzstan : SingletonCountryBase<Kyrgyzstan>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Kyrgyzstan";
        private const string _countryCode = "KG";

        public Kyrgyzstan() { }
    }
}

