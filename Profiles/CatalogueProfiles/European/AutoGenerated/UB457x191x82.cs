using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class UB457x191x82 : SingletonEuropeanBase<UB457x191x82>, IIParallelFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.UB;
        public override string Designation => "UB 457 × 191 × 82";
        public Length Height => new Length(460, LengthUnit.Millimeter);
        public Length Width => new Length(191.3, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(16, LengthUnit.Millimeter);
        public Length WebThickness => new Length(9.9, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(10, LengthUnit.Millimeter);

        public UB457x191x82() { }
    }
}
