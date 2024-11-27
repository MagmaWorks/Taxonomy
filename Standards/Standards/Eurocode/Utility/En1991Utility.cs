namespace MagmaWorks.Taxonomy.Standards.Eurocode
{
    internal static class En1991Utility
    {
        internal static string GetPartDescription(En1991Part part)
        {
            return part switch
            {
                En1991Part.Part1_1 => "Part 1-1: General actions - Densities, self-weight, imposed loads for buildings",
                En1991Part.Part1_2 => "Part 1-2: General actions - Actions on structures exposed to fire",
                En1991Part.Part1_3 => "Part 1-3: General actions - Snow loads",
                En1991Part.Part1_4 => "Part 1-4: General actions - Wind actions",
                En1991Part.Part1_5 => "Part 1-5: General actions - Thermal actions",
                En1991Part.Part1_6 => "Part 1-6: General actions - Actions during execution",
                En1991Part.Part1_7 => "Part 1-7: General actions - Accidental actions",
                En1991Part.Part2 => "Part 2: Traffic loads on bridges",
                En1991Part.Part3 => "Part 3: Actions induced by cranes and machinery",
                En1991Part.Part4 => "Part 4: Silos and tanks",

                _ => throw new System.ArgumentException("Unknown part"),
            };
        }
    }
}
