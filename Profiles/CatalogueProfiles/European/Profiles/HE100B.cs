using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HE100B : SingletonEuropeanBase<HE100B>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.HEB;
        public override string Label => "HE 100 B";
        public Length Height => new Length(100, LengthUnit.Millimeter);
        public Length Width => new Length(100, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(10, LengthUnit.Millimeter);
        public Length WebThickness => new Length(6, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(12, LengthUnit.Millimeter);

        public HE100B() { }
    }
}
