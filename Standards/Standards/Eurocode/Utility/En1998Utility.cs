namespace MagmaWorks.Taxonomy.Standards.Eurocode
{
    internal static class En1998Utility
    {
        internal static string GetPartDescription(En1998Part part)
        {
            return part switch
            {
                En1998Part.Part1 => "Part 1: General rules, seismic actions and rules for buildings",
                En1998Part.Part2 => "Part 2: Bridges",
                En1998Part.Part3 => "Part 3: Assessment and retrofitting of buildings",
                En1998Part.Part4 => "Part 4: Silos, tanks and pipelines",
                En1998Part.Part5 => "Part 5: Foundations, retaining structures and geotechnical aspects",
                En1998Part.Part6 => "Part 6: Towers, masts and chimneys",
                _ => throw new System.ArgumentException("Unknown part"),
            };
        }
    }
}
