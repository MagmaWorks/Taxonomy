using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HE180B : SingletonEuropeanBase<HE180B>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.HEB;
        public override string Label => "HE 180 B";
        public Length Height => new Length(180, LengthUnit.Millimeter);
        public Length Width => new Length(180, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(14, LengthUnit.Millimeter);
        public Length WebThickness => new Length(8.5, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(15, LengthUnit.Millimeter);

        public HE180B() { }
    }
}
