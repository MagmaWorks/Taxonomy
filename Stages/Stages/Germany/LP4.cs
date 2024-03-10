namespace MagmaWorks.Taxonomy.Stages.HOAI
{
    public class LP4 : ISchematicDesign
    {
        public string Name => _name;
        public string Description => _description;
        public string Id => _id;
        public IGovernance Governance => _governance;

        private const string _name = "Leistungsphase 4";
        private const string _description = "Genehmigungsplanung (Building permission application)";
        private const string _id = "4";
        private static readonly IGovernance _governance = new HOAI();

        public LP4() { }
    }
}
