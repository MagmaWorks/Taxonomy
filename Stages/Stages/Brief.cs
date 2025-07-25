namespace MagmaWorks.Taxonomy.Stages
{
    public class Brief : IBrief
    {
        public string Name => _name;
        public string Description => _description;
        public string Id => _id;

        public IGovernance Governance => new International();

        private const string _name = "Brief";
        private const string _description = "Predesign Brief phase";
        private const string _id = "2";

        public Brief() { }
    }
}
