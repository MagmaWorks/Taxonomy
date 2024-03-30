using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class UPN280 : SingletonEuropeanBase<UPN280>, IChannelTaperFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.UPN;
        public override string Designation => "UPN 280";
        public Length Height => new Length(280, LengthUnit.Millimeter);
        public Length Width => new Length(95, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(15, LengthUnit.Millimeter);
        public Length WebThickness => new Length(10, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(15, LengthUnit.Millimeter);
        public Length ToeRadius => new Length(7.5, LengthUnit.Millimeter);
        public Length WebHeight => new Length(216, LengthUnit.Millimeter);

        public UPN280() { }
    }
}
