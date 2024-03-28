using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HLZ1100B : SingletonEuropeanBase<HLZ1100B>, IITaperFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.HLZ;
        public override string Designation => "HLZ 1100 B";
        public Length Height => new Length(1079.4, LengthUnit.Millimeter);
        public Length Width => new Length(458, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(33, LengthUnit.Millimeter);
        public Length WebThickness => new Length(20, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(35, LengthUnit.Millimeter);
        public Length ToeRadius => new Length(0, LengthUnit.Millimeter);
        public Length WebHeight => new Length(935.9, LengthUnit.Millimeter);

        public HLZ1100B() { }
    }
}

