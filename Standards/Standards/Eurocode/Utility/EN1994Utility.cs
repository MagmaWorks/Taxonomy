namespace MagmaWorks.Taxonomy.Standards.Eurocode
{
    internal static class EN1994Utility
    {
        internal static string GetPartDescription(EN1994Part part)
        {
            return part switch
            {
                EN1994Part.Part1_1 => "Part 1-1: General rules and rules for buildings",
                EN1994Part.Part1_2 => "Part 1-2: General rules - Structural fire design",
                EN1994Part.Part2 => "Part 2: General rules and rules for bridges",
                _ => throw new System.ArgumentException("Unknown part"),
            };
        }
    }
}
