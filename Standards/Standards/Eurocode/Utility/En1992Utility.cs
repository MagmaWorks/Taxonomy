namespace MagmaWorks.Taxonomy.Standards.Eurocode
{
    internal static class En1992Utility
    {
        internal static string GetPartDescription(En1992Part part)
        {
            return part switch
            {
                En1992Part.Part1_1 => "Part 1-1: General rules and rules for buildings",
                En1992Part.Part1_2 => "Part 1-2: General rules - Structural fire design",
                En1992Part.Part2 => "Part 2: Concrete bridges - Design and detailing rules",
                En1992Part.Part3 => "Part 3: Liquid retaining and containment structures",

                _ => throw new System.ArgumentException("Unknown part"),
            };
        }
    }
}
