using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class UC152x152x23 : SingletonEuropeanBase<UC152x152x23>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.UC;
        public override string Label => "UC 152 × 152 × 23";
        public Length Height => new Length(152.4, LengthUnit.Millimeter);
        public Length Width => new Length(152.2, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(6.8, LengthUnit.Millimeter);
        public Length WebThickness => new Length(5.8, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(8, LengthUnit.Millimeter);

        public UC152x152x23() { }
    }
}
