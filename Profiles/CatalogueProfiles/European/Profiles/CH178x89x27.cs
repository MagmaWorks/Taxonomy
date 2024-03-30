using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class CH178x89x27 : SingletonEuropeanBase<CH178x89x27>, IChannelTaperFlange
    {
        public override EuropeanShape Shape => EuropeanShape.CH;
        public override string Label => "CH 178 × 89 × 27";
        public Length Height => new Length(177.8, LengthUnit.Millimeter);
        public Length Width => new Length(88.9, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(12.3, LengthUnit.Millimeter);
        public Length WebThickness => new Length(7.6, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(17, LengthUnit.Millimeter);
        public Length ToeRadius => new Length(8.5, LengthUnit.Millimeter);
        public Length WebHeight => new Length(116, LengthUnit.Millimeter);

        public CH178x89x27() { }
    }
}
