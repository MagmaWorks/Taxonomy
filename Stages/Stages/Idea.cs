using MagmaWorks.Taxonomy.Stages.RIBA;

namespace MagmaWorks.Taxonomy.Stages
{
    public class Idea : IIdea
    {
        public string Name => _name;
        public string Description => _description;
        public string Id => _id;

        public IGovernance Governance => new WhitbyWoodGoverned();

        private const string _name = "Idea";
        private const string _description = "Predesign Idea phase";
        private const string _id = "1";

        public Idea() { }
    }
}
