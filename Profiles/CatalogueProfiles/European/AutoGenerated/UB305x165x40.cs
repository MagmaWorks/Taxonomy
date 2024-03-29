using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class UB305x165x40 : SingletonEuropeanBase<UB305x165x40>, IIParallelFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.UB;
        public override string Designation => "UB 305 × 165 × 40";
        public Length Height => new Length(303.4, LengthUnit.Millimeter);
        public Length Width => new Length(165, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(10.2, LengthUnit.Millimeter);
        public Length WebThickness => new Length(6, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(8.9, LengthUnit.Millimeter);

        public UB305x165x40() { }
    }
}
