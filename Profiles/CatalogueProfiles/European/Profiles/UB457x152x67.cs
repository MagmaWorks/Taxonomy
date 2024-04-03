using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class UB457x152x67 : SingletonEuropeanBase<UB457x152x67>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.UB;
        public override string Label => "UB 457 × 152 × 67";
        public Length Height => new Length(458, LengthUnit.Millimeter);
        public Length Width => new Length(153.8, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(15, LengthUnit.Millimeter);
        public Length WebThickness => new Length(9, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(10, LengthUnit.Millimeter);

        public UB457x152x67() { }
    }
}
