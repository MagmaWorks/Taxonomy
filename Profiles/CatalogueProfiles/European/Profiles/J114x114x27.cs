using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class J114x114x27 : SingletonEuropeanBase<J114x114x27>, IITaperFlange
    {
        public override EuropeanShape Shape => EuropeanShape.J;
        public override string Label => "J 114 × 114 × 27";
        public Length Height => new Length(114.3, LengthUnit.Millimeter);
        public Length Width => new Length(114.3, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(10.7, LengthUnit.Millimeter);
        public Length WebThickness => new Length(9.5, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(15.2, LengthUnit.Millimeter);
        public Length ToeRadius => new Length(7.6, LengthUnit.Millimeter);
        public Length WebHeight => new Length(92.9, LengthUnit.Millimeter);

        public J114x114x27() { }
    }
}
