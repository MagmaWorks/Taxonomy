using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class UB1016x305x350 : SingletonEuropeanBase<UB1016x305x350>, IIParallelFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.UB;
        public override string Designation => "UB 1016 × 305 × 350";
        public Length Height => new Length(1008, LengthUnit.Millimeter);
        public Length Width => new Length(302, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(21.1, LengthUnit.Millimeter);
        public Length WebThickness => new Length(40, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(30, LengthUnit.Millimeter);

        public UB1016x305x350() { }
    }
}

