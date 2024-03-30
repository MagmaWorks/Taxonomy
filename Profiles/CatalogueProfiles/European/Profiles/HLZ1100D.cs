using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HLZ1100D : SingletonEuropeanBase<HLZ1100D>, IITaperFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.HLZ;
        public override string Designation => "HLZ 1100 D";
        public Length Height => new Length(1087.4, LengthUnit.Millimeter);
        public Length Width => new Length(460, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(37, LengthUnit.Millimeter);
        public Length WebThickness => new Length(22, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(35, LengthUnit.Millimeter);
        public Length ToeRadius => new Length(0, LengthUnit.Millimeter);
        public Length WebHeight => new Length(935.9, LengthUnit.Millimeter);

        public HLZ1100D() { }
    }
}
