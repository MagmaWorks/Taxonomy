using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class UB254x146x43 : SingletonEuropeanBase<UB254x146x43>, IIParallelFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.UB;
        public override string Designation => "UB 254 × 146 × 43";
        public Length Height => new Length(259.6, LengthUnit.Millimeter);
        public Length Width => new Length(147.3, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(7.2, LengthUnit.Millimeter);
        public Length WebThickness => new Length(12.7, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(8, LengthUnit.Millimeter);

        public UB254x146x43() { }
    }
}

