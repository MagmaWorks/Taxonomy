using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class UPN50 : SingletonEuropeanBase<UPN50>, IChannelTaperFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.UPN;
        public override string Designation => "UPN 50";
        public Length Height => new Length(50, LengthUnit.Millimeter);
        public Length Width => new Length(38, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(7, LengthUnit.Millimeter);
        public Length WebThickness => new Length(5, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(7, LengthUnit.Millimeter);
        public Length ToeRadius => new Length(3.5, LengthUnit.Millimeter);
        public Length WebHeight => new Length(21, LengthUnit.Millimeter);

        public UPN50() { }
    }
}
