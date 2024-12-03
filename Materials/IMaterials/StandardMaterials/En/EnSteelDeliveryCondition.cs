using System.ComponentModel;

namespace MagmaWorks.Taxonomy.Materials.StandardMaterials.En
{
    public enum EnSteelDeliveryCondition
    {
        [Description("As-rolled - EN10025-2")]
        AR,
        [Description("Normalised rolled in accordance with EN 10025-3")]
        N,
        [Description("Thermomechanical rolling in accordance with EN 10025-4")]
        M,
        [Description("Quenched and tempered in accordance with EN 10025-6")]
        Q
    }
}
