namespace MagmaWorks.Taxonomy.Standards.Eurocode
{
    internal static class En1995Utility
    {
        internal static string GetPartDescription(En1995Part part)
        {
            return part switch
            {
                En1995Part.Part1_1 => "Part 1-1: General - Common rules and rules for buildings",
                En1995Part.Part1_2 => "Part 1-2: General - Structural fire design",
                En1995Part.Part2 => "Part 2: Bridges",
                _ => throw new System.ArgumentException("Unknown part"),
            };
        }
    }
}
