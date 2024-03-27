namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class Cameroon : SingletonCountryBase<Cameroon>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Cameroon";
        private const string _countryCode = "CM";

        public Cameroon() { }
    }
}

