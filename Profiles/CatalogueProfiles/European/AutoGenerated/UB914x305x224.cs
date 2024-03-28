using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class UB914x305x224 : SingletonEuropeanBase<UB914x305x224>, IIParallelFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.UB;
        public override string Designation => "UB 914 × 305 × 224";
        public Length Height => new Length(910.4, LengthUnit.Millimeter);
        public Length Width => new Length(304.1, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(23.9, LengthUnit.Millimeter);
        public Length WebThickness => new Length(15.9, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(19, LengthUnit.Millimeter);

        public UB914x305x224() { }
    }
}

