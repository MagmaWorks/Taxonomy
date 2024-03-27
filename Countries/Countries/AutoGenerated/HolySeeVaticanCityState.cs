namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class HolySeeVaticanCityState : SingletonCountryBase<HolySeeVaticanCityState>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Holy See (Vatican City State)";
        private const string _countryCode = "VA";

        public HolySeeVaticanCityState() { }
    }
}

