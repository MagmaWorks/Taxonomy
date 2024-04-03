using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class UPN380 : SingletonEuropeanBase<UPN380>, IChannelTaperFlange
    {
        public override EuropeanShape Shape => EuropeanShape.UPN;
        public override string Label => "UPN 380";
        public Length Height => new Length(380, LengthUnit.Millimeter);
        public Length Width => new Length(102, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(16, LengthUnit.Millimeter);
        public Length WebThickness => new Length(13.5, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(16, LengthUnit.Millimeter);
        public Length ToeRadius => new Length(8, LengthUnit.Millimeter);
        public Length WebHeight => new Length(313, LengthUnit.Millimeter);

        public UPN380() { }
    }
}
