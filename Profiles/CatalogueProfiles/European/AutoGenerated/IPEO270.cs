using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class IPEO270 : SingletonEuropeanBase<IPEO270>, IIParallelFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.IPEO;
        public override string Designation => "IPE O 270";
        public Length Height => new Length(274, LengthUnit.Millimeter);
        public Length Width => new Length(136, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(7.5, LengthUnit.Millimeter);
        public Length WebThickness => new Length(12.2, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(15, LengthUnit.Millimeter);

        public IPEO270() { }
    }
}

