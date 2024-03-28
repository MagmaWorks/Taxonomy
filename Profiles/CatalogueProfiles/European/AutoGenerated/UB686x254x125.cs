using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class UB686x254x125 : SingletonEuropeanBase<UB686x254x125>, IIParallelFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.UB;
        public override string Designation => "UB 686 × 254 × 125";
        public Length Height => new Length(677.9, LengthUnit.Millimeter);
        public Length Width => new Length(253, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(11.7, LengthUnit.Millimeter);
        public Length WebThickness => new Length(16.2, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(15, LengthUnit.Millimeter);

        public UB686x254x125() { }
    }
}

