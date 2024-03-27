namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class Eritrea : SingletonCountryBase<Eritrea>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Eritrea";
        private const string _countryCode = "ER";

        public Eritrea() { }
    }
}

