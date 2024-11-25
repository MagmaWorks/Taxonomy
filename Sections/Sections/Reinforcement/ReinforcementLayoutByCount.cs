namespace MagmaWorks.Taxonomy.Sections.Reinforcement
{
    public class ReinforcementLayoutByCount : IReinforcementLayoutByCount
    {
        public int NumberOfBars { get; set; }
        public IRebar Rebar { get; set; }

        public ReinforcementLayoutByCount(IRebar rebar, int numberOfBars)
        {
            NumberOfBars = numberOfBars;
            Rebar = rebar;
        }
    }
}
