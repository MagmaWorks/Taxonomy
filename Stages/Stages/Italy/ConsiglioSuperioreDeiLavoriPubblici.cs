using MagmaWorks.Taxonomy.Countries;

namespace MagmaWorks.Taxonomy.Stages.Italy
{
    public class ConsiglioSuperioreDeiLavoriPubblici : IGovernance
    {
        public string Name => _name;
        public string FullBodyName => _fullBodyName;
        public ICountry Country => _country;

        private const string _name = "CSLP";
        private const string _fullBodyName = "Consiglio Superiore dei Lavori Pubblici";
        private static readonly ICountry _country = new Countries.Italy();

        public ConsiglioSuperioreDeiLavoriPubblici() { }
    }
}
