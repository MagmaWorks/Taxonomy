namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class SaoTomeAndPrincipe : SingletonCountryBase<SaoTomeAndPrincipe>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Sao Tome and Principe";
        private const string _countryCode = "ST";

        public SaoTomeAndPrincipe() { }
    }
}

