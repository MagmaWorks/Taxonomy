using MagmaWorks.Taxonomy.Countries;

namespace MagmaWorks.Taxonomy.Stages.Denmark
{
    public class AB89 : IGovernance
    {
        public string Name => _name;
        public string FullBodyName => _fullBodyName;
        public ICountry Country => _country;

        private const string _name = "AB89";
        private const string _fullBodyName = "Foreningen af Rådgivende Ingeniører og Danske Arkitekvirksomheder";
        private static readonly ICountry _country = new Countries.Denmark();

        public AB89() { }
    }
}
