namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class AntiguaAndBarbuda : SingletonCountryBase<AntiguaAndBarbuda>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Antigua and Barbuda";
        private const string _countryCode = "AG";

        public AntiguaAndBarbuda() { }
    }
}

