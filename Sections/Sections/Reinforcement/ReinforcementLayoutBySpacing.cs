namespace MagmaWorks.Taxonomy.Sections.Reinforcement
{
    public class ReinforcementLayoutBySpacing : IReinforcementLayoutBySpacing
    {
        public Length MaximumSpacing { get; set; }
        public IRebar Rebar { get; set; }

        public ReinforcementLayoutBySpacing(IRebar rebar, Length maxSpacing)
        {
            MaximumSpacing = maxSpacing;
            Rebar = rebar;
        }
    }
}
