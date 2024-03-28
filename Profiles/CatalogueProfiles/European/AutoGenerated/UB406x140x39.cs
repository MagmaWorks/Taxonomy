using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class UB406x140x39 : SingletonEuropeanBase<UB406x140x39>, IIParallelFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.UB;
        public override string Designation => "UB 406 × 140 × 39";
        public Length Height => new Length(398, LengthUnit.Millimeter);
        public Length Width => new Length(141.8, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(8.6, LengthUnit.Millimeter);
        public Length WebThickness => new Length(6.4, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(10, LengthUnit.Millimeter);

        public UB406x140x39() { }
    }
}

