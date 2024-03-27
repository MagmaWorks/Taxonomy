namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class TimorLeste : SingletonCountryBase<TimorLeste>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Timor-Leste";
        private const string _countryCode = "TL";

        public TimorLeste() { }
    }
}

