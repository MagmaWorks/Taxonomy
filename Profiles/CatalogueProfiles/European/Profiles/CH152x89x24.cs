using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class CH152x89x24 : SingletonEuropeanBase<CH152x89x24>, IChannelTaperFlange
    {
        public override EuropeanShape Shape => EuropeanShape.CH;
        public override string Label => "CH 152 × 89 × 24";
        public Length Height => new Length(152.4, LengthUnit.Millimeter);
        public Length Width => new Length(88.9, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(11.6, LengthUnit.Millimeter);
        public Length WebThickness => new Length(7.1, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(16, LengthUnit.Millimeter);
        public Length ToeRadius => new Length(8, LengthUnit.Millimeter);
        public Length WebHeight => new Length(93.7, LengthUnit.Millimeter);

        public CH152x89x24() { }
    }
}
