namespace MagmaWorks.Taxonomy.Standards.Eurocode
{
    internal static class En1997Utility
    {
        internal static string GetPartDescription(En1997Part part)
        {
            return part switch
            {
                En1997Part.Part1 => "Part 1: General rules",
                En1997Part.Part2 => "Part 2: Ground investigation and testing",
                _ => throw new System.ArgumentException("Unknown part"),
            };
        }
    }
}
