using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HE280B : SingletonEuropeanBase<HE280B>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.HEB;
        public override string Label => "HE 280 B";
        public Length Height => new Length(280, LengthUnit.Millimeter);
        public Length Width => new Length(280, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(18, LengthUnit.Millimeter);
        public Length WebThickness => new Length(10.5, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(24, LengthUnit.Millimeter);

        public HE280B() { }
    }
}
