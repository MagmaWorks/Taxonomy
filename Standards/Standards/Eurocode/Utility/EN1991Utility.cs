namespace MagmaWorks.Taxonomy.Standards.Eurocode
{
    internal static class EN1991Utility
    {
        internal static string GetPartDescription(EN1991Part part)
        {
            return part switch
            {
                EN1991Part.Part1_1 => "Part 1-1: General actions - Densities, self-weight, imposed loads for buildings",
                EN1991Part.Part1_2 => "Part 1-2: General actions - Actions on structures exposed to fire",
                EN1991Part.Part1_3 => "Part 1-3: General actions - Snow loads",
                EN1991Part.Part1_4 => "Part 1-4: General actions - Wind actions",
                EN1991Part.Part1_5 => "Part 1-5: General actions - Thermal actions",
                EN1991Part.Part1_6 => "Part 1-6: General actions - Actions during execution",
                EN1991Part.Part1_7 => "Part 1-7: General actions - Accidental actions",
                EN1991Part.Part2 => "Part 2: Traffic loads on bridges",
                EN1991Part.Part3 => "Part 3: Actions induced by cranes and machinery",
                EN1991Part.Part4 => "Part 4: Silos and tanks",

                _ => throw new System.ArgumentException("Unknown part"),
            };
        }
    }
}
