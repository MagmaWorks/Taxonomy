namespace MagmaWorks.Taxonomy.Standards.Eurocode
{
    internal static class En1993Utility
    {
        internal static string GetPartDescription(En1993Part part)
        {
            return part switch
            {
                En1993Part.Part1_1 => "Part 1-1: General rules and rules for buildings",
                En1993Part.Part1_2 => "Part 1-2: General rules - Structural fire design",
                En1993Part.Part1_3 => "Part 1-3: General rules - Supplementary rules for cold-formed members and sheeting",
                En1993Part.Part1_4 => "Part 1-4: General rules - Supplementary rules for stainless steels",
                En1993Part.Part1_5 => "Part 1-5: General rules - Plated structural elements",
                En1993Part.Part1_6 => "Part 1-6: Strength and stability of shell structures",
                En1993Part.Part1_7 => "Part 1-7: Strength and stability of planar plated structures subject to out of plane loading",
                En1993Part.Part1_8 => "Part 1-8: Design of joints",
                En1993Part.Part1_9 => "Part 1-9: Fatigue",
                En1993Part.Part1_10 => "Part 1-10: Material toughness and through-thickness properties",
                En1993Part.Part1_11 => "Part 1-11: Design of structures with tension components",
                En1993Part.Part1_12 => "Part 1-12: General - High strength steels",
                En1993Part.Part2 => "Part 2: Steel bridges",
                En1993Part.Part3_1 => "Part 3-1: Towers, masts and chimneys – Towers and masts",
                En1993Part.Part3_2 => "Part 3-2: Towers, masts and chimneys – Chimneys",
                En1993Part.Part4_1 => "Part 4-1: Silos",
                En1993Part.Part4_2 => "Part 4-2: Tanks",
                En1993Part.Part4_3 => "Part 4-3: Pipelines",
                En1993Part.Part5 => "Part 5: Piling",
                En1993Part.Part6 => "Part 6: Crane supporting structures",
                _ => throw new System.ArgumentException("Unknown part"),
            };
        }
    }
}
