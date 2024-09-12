namespace MagmaWorks.Taxonomy.Standards.Eurocode
{
    internal static class EN1998Utility
    {
        internal static string GetPartDescription(EN1998Part part)
        {
            return part switch
            {
                EN1998Part.Part1 => "Part 1: General rules, seismic actions and rules for buildings",
                EN1998Part.Part2 => "Part 2: Bridges",
                EN1998Part.Part3 => "Part 3: Assessment and retrofitting of buildings",
                EN1998Part.Part4 => "Part 4: Silos, tanks and pipelines",
                EN1998Part.Part5 => "Part 5: Foundations, retaining structures and geotechnical aspects",
                EN1998Part.Part6 => "Part 6: Towers, masts and chimneys",
                _ => throw new System.ArgumentException("Unknown part"),
            };
        }
    }
}
