namespace MagmaWorks.Taxonomy.Stages
{
    public class ConceptDesign : IConceptualDesign
    {
        public string Name => _name;
        public string Description => _description;
        public string Id => _id;

        public IGovernance Governance => new International();

        private const string _name = "Concept Design";
        private const string _description = "Concept Design phase";
        private const string _id = "4";

        public ConceptDesign() { }
    }
}
