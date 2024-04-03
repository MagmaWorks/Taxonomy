using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HE140A : SingletonEuropeanBase<HE140A>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.HEA;
        public override string Label => "HE 140 A";
        public Length Height => new Length(133, LengthUnit.Millimeter);
        public Length Width => new Length(140, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(8.5, LengthUnit.Millimeter);
        public Length WebThickness => new Length(5.5, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(12, LengthUnit.Millimeter);

        public HE140A() { }
    }
}
