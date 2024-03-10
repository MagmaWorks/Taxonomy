namespace MagmaWorks.Taxonomy.Stages.AB89
{
    public class Hovedprojekt : IDetailedDesign
    {
        public string Name => _name;
        public string Description => _description;
        public string Id => _id;
        public IGovernance Governance => _governance;

        private const string _name = "Hovedprojekt";
        private const string _description = "Hovedprojekt (Main project, preparation for tender)";
        private const string _id = "5";
        private static readonly IGovernance _governance = new AB89();

        public Hovedprojekt() { }
    }
}
