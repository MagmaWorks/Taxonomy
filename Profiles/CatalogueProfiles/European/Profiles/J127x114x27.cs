using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class J127x114x27 : SingletonEuropeanBase<J127x114x27>, IITaperFlange
    {
        public override EuropeanShape Shape => EuropeanShape.J;
        public override string Label => "J 127 × 114 × 27";
        public Length Height => new Length(127, LengthUnit.Millimeter);
        public Length Width => new Length(114.3, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(11.4, LengthUnit.Millimeter);
        public Length WebThickness => new Length(7.4, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(9.9, LengthUnit.Millimeter);
        public Length ToeRadius => new Length(5, LengthUnit.Millimeter);
        public Length WebHeight => new Length(104.2, LengthUnit.Millimeter);

        public J127x114x27() { }
    }
}
