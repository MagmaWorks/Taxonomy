namespace MagmaWorks.Taxonomy.Standards.Eurocode
{
    internal static class En1996Utility
    {
        internal static string GetPartDescription(En1996Part part)
        {
            return part switch
            {
                En1996Part.Part1_1 => "Part 1-1: General rules for reinforced and unreinforced masonry structures",
                En1996Part.Part1_2 => "Part 1-2: General rules - Structural fire design",
                En1996Part.Part2 => "Part 2: Design considerations, selection of materials and execution of masonry",
                En1996Part.Part3 => "Part 3: Simplified calculation methods for unreinforced masonry structures",
                _ => throw new System.ArgumentException("Unknown part"),
            };
        }
    }
}
