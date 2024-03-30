using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class UPN260 : SingletonEuropeanBase<UPN260>, IChannelTaperFlange
    {
        public override EuropeanShape Shape => EuropeanShape.UPN;
        public override string Label => "UPN 260";
        public Length Height => new Length(260, LengthUnit.Millimeter);
        public Length Width => new Length(90, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(14, LengthUnit.Millimeter);
        public Length WebThickness => new Length(10, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(14, LengthUnit.Millimeter);
        public Length ToeRadius => new Length(7, LengthUnit.Millimeter);
        public Length WebHeight => new Length(200, LengthUnit.Millimeter);

        public UPN260() { }
    }
}
