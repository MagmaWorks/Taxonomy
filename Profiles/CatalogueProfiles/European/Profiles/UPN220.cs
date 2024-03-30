using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class UPN220 : SingletonEuropeanBase<UPN220>, IChannelTaperFlange
    {
        public override EuropeanShape Shape => EuropeanShape.UPN;
        public override string Label => "UPN 220";
        public Length Height => new Length(220, LengthUnit.Millimeter);
        public Length Width => new Length(80, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(12.5, LengthUnit.Millimeter);
        public Length WebThickness => new Length(9, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(12.5, LengthUnit.Millimeter);
        public Length ToeRadius => new Length(6.5, LengthUnit.Millimeter);
        public Length WebHeight => new Length(167, LengthUnit.Millimeter);

        public UPN220() { }
    }
}
