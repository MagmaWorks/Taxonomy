namespace MagmaWorks.Taxonomy.Standards.Eurocode
{
    internal static class EN1992Utility
    {
        internal static string GetPartDescription(EN1992Part part)
        {
            return part switch
            {
                EN1992Part.Part1_1 => "Part 1-1: General rules and rules for buildings",
                EN1992Part.Part1_2 => "Part 1-2: General rules - Structural fire design",
                EN1992Part.Part2 => "Part 2: Concrete bridges - Design and detailing rules",
                EN1992Part.Part3 => "Part 3: Liquid retaining and containment structures",

                _ => throw new System.ArgumentException("Unknown part"),
            };
        }
    }
}
