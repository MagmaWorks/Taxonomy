using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class IPEV450 : SingletonEuropeanBase<IPEV450>, IIParallelFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.IPEV;
        public override string Designation => "IPE V 450";
        public Length Height => new Length(460, LengthUnit.Millimeter);
        public Length Width => new Length(194, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(12.4, LengthUnit.Millimeter);
        public Length WebThickness => new Length(19.6, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(21, LengthUnit.Millimeter);

        public IPEV450() { }
    }
}

