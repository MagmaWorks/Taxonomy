using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HE450B : SingletonEuropeanBase<HE450B>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.HEB;
        public override string Label => "HE 450 B";
        public Length Height => new Length(450, LengthUnit.Millimeter);
        public Length Width => new Length(300, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(26, LengthUnit.Millimeter);
        public Length WebThickness => new Length(14, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(27, LengthUnit.Millimeter);

        public HE450B() { }
    }
}
