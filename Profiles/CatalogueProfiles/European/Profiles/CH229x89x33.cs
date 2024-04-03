using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class CH229x89x33 : SingletonEuropeanBase<CH229x89x33>, IChannelTaperFlange
    {
        public override EuropeanShape Shape => EuropeanShape.CH;
        public override string Label => "CH 229 × 89 × 33";
        public Length Height => new Length(228.6, LengthUnit.Millimeter);
        public Length Width => new Length(88.9, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(13.3, LengthUnit.Millimeter);
        public Length WebThickness => new Length(8.6, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(19, LengthUnit.Millimeter);
        public Length ToeRadius => new Length(9.5, LengthUnit.Millimeter);
        public Length WebHeight => new Length(161, LengthUnit.Millimeter);

        public CH229x89x33() { }
    }
}
