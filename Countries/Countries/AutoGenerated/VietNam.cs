namespace MagmaWorks.Taxonomy.Countries
{
    public sealed class VietNam : SingletonCountryBase<VietNam>, ICountry
    {
        public string Name => _name;
        public string CountryCode => _countryCode;

        private const string _name = "Viet Nam";
        private const string _countryCode = "VN";

        public VietNam() { }
    }
}

