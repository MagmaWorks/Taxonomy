using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class UPN300 : SingletonEuropeanBase<UPN300>, IChannelTaperFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.UPN;
        public override string Designation => "UPN 300";
        public Length Height => new Length(300, LengthUnit.Millimeter);
        public Length Width => new Length(100, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(10, LengthUnit.Millimeter);
        public Length WebThickness => new Length(16, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(16, LengthUnit.Millimeter);
        public Length ToeRadius => new Length(8, LengthUnit.Millimeter);
        public Length WebHeight => new Length(232, LengthUnit.Millimeter);

        public UPN300() { }
    }
}

