using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HE1000x249 : SingletonEuropeanBase<HE1000x249>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.HE;
        public override string Label => "HE 1000 × 249";
        public Length Height => new Length(980, LengthUnit.Millimeter);
        public Length Width => new Length(300, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(26, LengthUnit.Millimeter);
        public Length WebThickness => new Length(16.5, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(30, LengthUnit.Millimeter);

        public HE1000x249() { }
    }
}
