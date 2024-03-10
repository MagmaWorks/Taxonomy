namespace MagmaWorks.Taxonomy.Stages.RIBA
{
    public class RIBAStage3 : ISchematicDesign
    {
        public string Name => _name;
        public string Description => _description;
        public string Id => _id;
        public IGovernance Governance => _governance;

        private const string _name = "RIBA Stage 3";
        private const string _description = "Developed Design - Spatial Coordination";
        private const string _id = "3";
        private static readonly IGovernance _governance = new RIBA();

        public RIBAStage3() { }
    }
}
