using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class IPEA550 : SingletonEuropeanBase<IPEA550>, IIParallelFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.IPEA;
        public override string Designation => "IPE A 550";
        public Length Height => new Length(547, LengthUnit.Millimeter);
        public Length Width => new Length(210, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(15.7, LengthUnit.Millimeter);
        public Length WebThickness => new Length(9, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(24, LengthUnit.Millimeter);

        public IPEA550() { }
    }
}

