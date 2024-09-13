namespace MagmaWorks.Taxonomy.Standards.Eurocode
{
    internal static class EurocodeUtility
    {
        internal static string GetCodeNumber(IEurocode eurocode)
        {
            string part = string.Empty;
            if (eurocode.Part.ToString() != "None")
            {
                part = '-' + eurocode.Part.ToString()
                .Replace("Part", string.Empty).Replace('_', '-').Replace("None", string.Empty);
            }

            return eurocode.Code.ToString().Replace("EN", "EN ") + part;
        }

        internal static string GetCodeTitle(Eurocode eurocode)
        {
            return eurocode switch
            {
                Eurocode.EN1990 => "Eurocode - Basis of Structural Design",
                Eurocode.EN1991 => "Eurocode 1: Actions on Structures",
                Eurocode.EN1992 => "Eurocode 2: Design of Concrete Structures",
                Eurocode.EN1993 => "Eurocode 3: Design of Steel Structures",
                Eurocode.EN1994 => "Eurocode 4: Design of Composite Steel & Concrete Structures",
                Eurocode.EN1995 => "Eurocode 5: Design of Timber Structures",
                Eurocode.EN1996 => "Eurocode 6: Design of Masonry Structures",
                Eurocode.EN1997 => "Eurocode 7: Geotechnical Design",
                Eurocode.EN1998 => "Eurocode 8: Design of Structures for Earthquake Resistance",
                Eurocode.EN1999 => "Eurocode 9: Design of Aluminium Structures",
                _ => throw new System.ArgumentException("Unknown Eurocode"),
            };
        }
    }
}
