namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class PapuaNewGuinea : SingletonCountryBase<PapuaNewGuinea>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Papua New Guinea";
        private const string _countryCode = "PG";

        public PapuaNewGuinea() { }
    }
}

