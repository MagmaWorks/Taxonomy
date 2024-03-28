using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class UPN320 : SingletonEuropeanBase<UPN320>, IChannelTaperFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.UPN;
        public override string Designation => "UPN 320";
        public Length Height => new Length(320, LengthUnit.Millimeter);
        public Length Width => new Length(100, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(17.5, LengthUnit.Millimeter);
        public Length WebThickness => new Length(14, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(17.5, LengthUnit.Millimeter);
        public Length ToeRadius => new Length(8.8, LengthUnit.Millimeter);
        public Length WebHeight => new Length(246, LengthUnit.Millimeter);

        public UPN320() { }
    }
}

