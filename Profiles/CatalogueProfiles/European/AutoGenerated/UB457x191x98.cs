using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class UB457x191x98 : SingletonEuropeanBase<UB457x191x98>, IIParallelFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.UB;
        public override string Designation => "UB 457 × 191 × 98";
        public Length Height => new Length(467.2, LengthUnit.Millimeter);
        public Length Width => new Length(192.8, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(11.4, LengthUnit.Millimeter);
        public Length WebThickness => new Length(19.6, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(10, LengthUnit.Millimeter);

        public UB457x191x98() { }
    }
}

