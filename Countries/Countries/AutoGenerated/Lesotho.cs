namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class Lesotho : SingletonCountryBase<Lesotho>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Lesotho";
        private const string _countryCode = "LS";

        public Lesotho() { }
    }
}

