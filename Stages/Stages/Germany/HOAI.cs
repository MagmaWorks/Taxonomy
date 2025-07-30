using MagmaWorks.Taxonomy.Countries;

namespace MagmaWorks.Taxonomy.Stages.Germany
{
    public class HOAI : IGovernance
    {
        public string Name => _name;
        public string FullBodyName => _fullBodyName;
        public ICountry Country => _country;

        private const string _name = "HOAI";
        private const string _fullBodyName = "Honorarordnung für Architekten und Ingenieure";
        private static readonly ICountry _country = new Countries.Germany();

        public HOAI() { }
    }
}
