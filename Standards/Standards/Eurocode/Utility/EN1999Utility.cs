namespace MagmaWorks.Taxonomy.Standards.Eurocode
{
    internal static class EN1999Utility
    {
        internal static string GetPartDescription(EN1999Part part)
        {
            return part switch
            {
                EN1999Part.Part1_1 => "Part 1-1: General structural rules",
                EN1999Part.Part1_2 => "Part 1-2: Structural fire design",
                EN1999Part.Part1_3 => "Part 1-3: Structures susceptible to fatigue",
                EN1999Part.Part1_4 => "Part 1-4: Cold-formed structural sheeting",
                EN1999Part.Part1_5 => "Part 1-5: Shell structures",
                _ => throw new System.ArgumentException("Unknown part"),
            };
        }
    }
}
