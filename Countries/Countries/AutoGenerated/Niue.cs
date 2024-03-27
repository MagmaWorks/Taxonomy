namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class Niue : SingletonCountryBase<Niue>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Niue";
        private const string _countryCode = "NU";

        public Niue() { }
    }
}

