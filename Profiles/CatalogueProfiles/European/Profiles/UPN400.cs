using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class UPN400 : SingletonEuropeanBase<UPN400>, IChannelTaperFlange
    {
        public override EuropeanShape Shape => EuropeanShape.UPN;
        public override string Label => "UPN 400";
        public Length Height => new Length(400, LengthUnit.Millimeter);
        public Length Width => new Length(110, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(18, LengthUnit.Millimeter);
        public Length WebThickness => new Length(14, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(18, LengthUnit.Millimeter);
        public Length ToeRadius => new Length(9, LengthUnit.Millimeter);
        public Length WebHeight => new Length(324, LengthUnit.Millimeter);

        public UPN400() { }
    }
}
