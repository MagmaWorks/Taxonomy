using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class UBP356x368x174 : SingletonEuropeanBase<UBP356x368x174>, IIParallelFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.UBP;
        public override string Designation => "UBP 356 × 368 × 174";
        public Length Height => new Length(361.4, LengthUnit.Millimeter);
        public Length Width => new Length(378.5, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(20.4, LengthUnit.Millimeter);
        public Length WebThickness => new Length(20.3, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(15, LengthUnit.Millimeter);

        public UBP356x368x174() { }
    }
}

