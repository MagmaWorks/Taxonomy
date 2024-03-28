using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class UPN350 : SingletonEuropeanBase<UPN350>, IChannelTaperFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.UPN;
        public override string Designation => "UPN 350";
        public Length Height => new Length(350, LengthUnit.Millimeter);
        public Length Width => new Length(100, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(16, LengthUnit.Millimeter);
        public Length WebThickness => new Length(14, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(16, LengthUnit.Millimeter);
        public Length ToeRadius => new Length(8, LengthUnit.Millimeter);
        public Length WebHeight => new Length(282, LengthUnit.Millimeter);

        public UPN350() { }
    }
}

