namespace MagmaWorks.Taxonomy.Standards.Eurocode
{
    internal static class En1999Utility
    {
        internal static string GetPartDescription(En1999Part part)
        {
            return part switch
            {
                En1999Part.Part1_1 => "Part 1-1: General structural rules",
                En1999Part.Part1_2 => "Part 1-2: Structural fire design",
                En1999Part.Part1_3 => "Part 1-3: Structures susceptible to fatigue",
                En1999Part.Part1_4 => "Part 1-4: Cold-formed structural sheeting",
                En1999Part.Part1_5 => "Part 1-5: Shell structures",
                _ => throw new System.ArgumentException("Unknown part"),
            };
        }
    }
}
