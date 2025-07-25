namespace MagmaWorks.Taxonomy.Stages.Italy
{
    public class Collaudo : IHandover
    {
        public string Name => _name;
        public string Description => _description;
        public string Id => _id;
        public IGovernance Governance => _governance;

        private const string _name = "Collaudo";
        private const string _description = "Collaudo";
        private const string _id = "5";
        private static readonly IGovernance _governance = new ConsiglioSuperioreDeiLavoriPubblici();

        public Collaudo() { }
    }
}
