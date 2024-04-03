using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HE600x399 : SingletonEuropeanBase<HE600x399>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.HE;
        public override string Label => "HE 600 × 399";
        public Length Height => new Length(648, LengthUnit.Millimeter);
        public Length Width => new Length(315, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(54, LengthUnit.Millimeter);
        public Length WebThickness => new Length(30, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(27, LengthUnit.Millimeter);

        public HE600x399() { }
    }
}
