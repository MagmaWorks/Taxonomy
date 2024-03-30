using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class UC152x152x30 : SingletonEuropeanBase<UC152x152x30>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.UC;
        public override string Label => "UC 152 × 152 × 30";
        public Length Height => new Length(157.6, LengthUnit.Millimeter);
        public Length Width => new Length(152.9, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(9.4, LengthUnit.Millimeter);
        public Length WebThickness => new Length(6.5, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(8, LengthUnit.Millimeter);

        public UC152x152x30() { }
    }
}
