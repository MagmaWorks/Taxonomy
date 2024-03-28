using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class UB914x305x201 : SingletonEuropeanBase<UB914x305x201>, IIParallelFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.UB;
        public override string Designation => "UB 914 × 305 × 201";
        public Length Height => new Length(903, LengthUnit.Millimeter);
        public Length Width => new Length(303.3, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(15.1, LengthUnit.Millimeter);
        public Length WebThickness => new Length(20.2, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(19, LengthUnit.Millimeter);

        public UB914x305x201() { }
    }
}

