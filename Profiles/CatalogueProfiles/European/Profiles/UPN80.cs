using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class UPN80 : SingletonEuropeanBase<UPN80>, IChannelTaperFlange
    {
        public override EuropeanShape Shape => EuropeanShape.UPN;
        public override string Label => "UPN 80";
        public Length Height => new Length(80, LengthUnit.Millimeter);
        public Length Width => new Length(45, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(8, LengthUnit.Millimeter);
        public Length WebThickness => new Length(6, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(8, LengthUnit.Millimeter);
        public Length ToeRadius => new Length(4, LengthUnit.Millimeter);
        public Length WebHeight => new Length(47, LengthUnit.Millimeter);

        public UPN80() { }
    }
}
