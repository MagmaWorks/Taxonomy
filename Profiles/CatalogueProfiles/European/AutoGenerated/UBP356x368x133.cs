using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class UBP356x368x133 : SingletonEuropeanBase<UBP356x368x133>, IIParallelFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.UBP;
        public override string Designation => "UBP 356 × 368 × 133";
        public Length Height => new Length(352, LengthUnit.Millimeter);
        public Length Width => new Length(373.8, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(15.6, LengthUnit.Millimeter);
        public Length WebThickness => new Length(15.7, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(15, LengthUnit.Millimeter);

        public UBP356x368x133() { }
    }
}

