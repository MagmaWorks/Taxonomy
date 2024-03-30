using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class J254x114x37 : SingletonEuropeanBase<J254x114x37>, IITaperFlange
    {
        public override EuropeanShape Shape => EuropeanShape.J;
        public override string Label => "J 254 × 114 × 37";
        public Length Height => new Length(254, LengthUnit.Millimeter);
        public Length Width => new Length(114.3, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(12.8, LengthUnit.Millimeter);
        public Length WebThickness => new Length(7.6, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(12.4, LengthUnit.Millimeter);
        public Length ToeRadius => new Length(6.2, LengthUnit.Millimeter);
        public Length WebHeight => new Length(200, LengthUnit.Millimeter);

        public J254x114x37() { }
    }
}
