using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HE360A : SingletonEuropeanBase<HE360A>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.HEA;
        public override string Label => "HE 360 A";
        public Length Height => new Length(350, LengthUnit.Millimeter);
        public Length Width => new Length(300, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(17.5, LengthUnit.Millimeter);
        public Length WebThickness => new Length(10, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(27, LengthUnit.Millimeter);

        public HE360A() { }
    }
}
