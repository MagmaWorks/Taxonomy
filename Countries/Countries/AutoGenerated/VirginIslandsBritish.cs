namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class VirginIslandsBritish : SingletonCountryBase<VirginIslandsBritish>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Virgin Islands British";
        private const string _countryCode = "VG";

        public VirginIslandsBritish() { }
    }
}

