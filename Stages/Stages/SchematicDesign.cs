namespace MagmaWorks.Taxonomy.Stages
{
    public class SchematicDesign : ISchematicDesign
    {
        public string Name => _name;
        public string Description => _description;
        public string Id => _id;

        public IGovernance Governance => new International();

        private const string _name = "Schematic Design";
        private const string _description = "Scheme Design phase";
        private const string _id = "5";

        public SchematicDesign() { }
    }
}
