namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class LaoPeoplesDemocraticRepublic : SingletonCountryBase<LaoPeoplesDemocraticRepublic>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Lao People's Democratic Republic";
        private const string _countryCode = "LA";

        public LaoPeoplesDemocraticRepublic() { }
    }
}

