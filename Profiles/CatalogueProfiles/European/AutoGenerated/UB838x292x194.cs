using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class UB838x292x194 : SingletonEuropeanBase<UB838x292x194>, IIParallelFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.UB;
        public override string Designation => "UB 838 × 292 × 194";
        public Length Height => new Length(840.7, LengthUnit.Millimeter);
        public Length Width => new Length(292.4, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(14.7, LengthUnit.Millimeter);
        public Length WebThickness => new Length(21.7, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(18, LengthUnit.Millimeter);

        public UB838x292x194() { }
    }
}

