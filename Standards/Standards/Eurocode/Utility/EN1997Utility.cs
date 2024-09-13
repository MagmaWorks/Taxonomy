namespace MagmaWorks.Taxonomy.Standards.Eurocode
{
    internal static class EN1997Utility
    {
        internal static string GetPartDescription(EN1997Part part)
        {
            return part switch
            {
                EN1997Part.Part1 => "Part 1: General rules",
                EN1997Part.Part2 => "Part 2: Ground investigation and testing",
                _ => throw new System.ArgumentException("Unknown part"),
            };
        }
    }
}
