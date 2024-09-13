using System.ComponentModel;

namespace MagmaWorks.Taxonomy.Standards.Eurocode
{
    public enum EN1991Part
    {
        [Description("Dead loads")]
        Part1_1,
        [Description("Fire")]
        Part1_2,
        [Description("Snow loads")]
        Part1_3,
        [Description("Wind loads")]
        Part1_4,
        [Description("Thermal loads")]
        Part1_5,
        [Description("Construction loads")]
        Part1_6,
        [Description("Accidental loads")]
        Part1_7,
        [Description("Bridge traffic loads")]
        Part2,
        [Description("Crane & machinery loads")]
        Part3,
        [Description("Silos and tanks")]
        Part4
    }
}
