namespace MagmaWorks.Taxonomy.Sections.Reinforcement
{
    public interface ILongitudinalReinforcement : IComposite
    {
        IRebar Rebar { get; }
        int CountPerBundle { get; }
    }
}
