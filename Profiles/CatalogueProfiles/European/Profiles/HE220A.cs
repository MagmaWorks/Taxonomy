using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HE220A : SingletonEuropeanBase<HE220A>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.HEA;
        public override string Label => "HE 220 A";
        public Length Height => new Length(210, LengthUnit.Millimeter);
        public Length Width => new Length(220, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(11, LengthUnit.Millimeter);
        public Length WebThickness => new Length(7, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(18, LengthUnit.Millimeter);

        public HE220A() { }
    }
}
