namespace MagmaWorks.Taxonomy.Stages.Italy
{
    public class DD : ISchematicDesign
    {
        public string Name => _name;
        public string Description => _description;
        public string Id => _id;
        public IGovernance Governance => _governance;

        private const string _name = "DD";
        private const string _description = "Progetto Definitivo";
        private const string _id = "2";
        private static readonly IGovernance _governance = new ConsiglioSuperioreDeiLavoriPubblici();

        public DD() { }
    }
}
