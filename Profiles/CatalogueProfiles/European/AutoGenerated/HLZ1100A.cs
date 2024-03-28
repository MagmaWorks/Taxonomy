using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HLZ1100A : SingletonEuropeanBase<HLZ1100A>, IITaperFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.HLZ;
        public override string Designation => "HLZ 1100 A";
        public Length Height => new Length(1075.4, LengthUnit.Millimeter);
        public Length Width => new Length(458, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(31, LengthUnit.Millimeter);
        public Length WebThickness => new Length(20, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(35, LengthUnit.Millimeter);
        public Length ToeRadius => new Length(0, LengthUnit.Millimeter);
        public Length WebHeight => new Length(935.9, LengthUnit.Millimeter);

        public HLZ1100A() { }
    }
}

