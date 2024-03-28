using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class UB457x191x89 : SingletonEuropeanBase<UB457x191x89>, IIParallelFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.UB;
        public override string Designation => "UB 457 × 191 × 89";
        public Length Height => new Length(463.4, LengthUnit.Millimeter);
        public Length Width => new Length(191.9, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(17.7, LengthUnit.Millimeter);
        public Length WebThickness => new Length(10.5, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(10, LengthUnit.Millimeter);

        public UB457x191x89() { }
    }
}

