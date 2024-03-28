using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class IPEA160 : SingletonEuropeanBase<IPEA160>, IIParallelFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.IPEA;
        public override string Designation => "IPE A 160";
        public Length Height => new Length(157, LengthUnit.Millimeter);
        public Length Width => new Length(82, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(4, LengthUnit.Millimeter);
        public Length WebThickness => new Length(5.9, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(9, LengthUnit.Millimeter);

        public IPEA160() { }
    }
}

