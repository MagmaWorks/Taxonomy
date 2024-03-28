using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class IPEO550 : SingletonEuropeanBase<IPEO550>, IIParallelFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.IPEO;
        public override string Designation => "IPE O 550";
        public Length Height => new Length(556, LengthUnit.Millimeter);
        public Length Width => new Length(212, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(12.7, LengthUnit.Millimeter);
        public Length WebThickness => new Length(20.2, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(24, LengthUnit.Millimeter);

        public IPEO550() { }
    }
}

