using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HE200B : SingletonEuropeanBase<HE200B>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.HEB;
        public override string Label => "HE 200 B";
        public Length Height => new Length(200, LengthUnit.Millimeter);
        public Length Width => new Length(200, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(15, LengthUnit.Millimeter);
        public Length WebThickness => new Length(9, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(18, LengthUnit.Millimeter);

        public HE200B() { }
    }
}
