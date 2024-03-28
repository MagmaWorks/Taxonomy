using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class UB914x419x343 : SingletonEuropeanBase<UB914x419x343>, IIParallelFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.UB;
        public override string Designation => "UB 914 × 419 × 343";
        public Length Height => new Length(911.8, LengthUnit.Millimeter);
        public Length Width => new Length(418.5, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(19.4, LengthUnit.Millimeter);
        public Length WebThickness => new Length(32, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(19, LengthUnit.Millimeter);

        public UB914x419x343() { }
    }
}

