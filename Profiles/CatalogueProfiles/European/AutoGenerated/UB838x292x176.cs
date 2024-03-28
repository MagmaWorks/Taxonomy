using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class UB838x292x176 : SingletonEuropeanBase<UB838x292x176>, IIParallelFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.UB;
        public override string Designation => "UB 838 × 292 × 176";
        public Length Height => new Length(834.9, LengthUnit.Millimeter);
        public Length Width => new Length(291.7, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(14, LengthUnit.Millimeter);
        public Length WebThickness => new Length(18.8, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(18, LengthUnit.Millimeter);

        public UB838x292x176() { }
    }
}

