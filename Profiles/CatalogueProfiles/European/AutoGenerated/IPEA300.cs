using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class IPEA300 : SingletonEuropeanBase<IPEA300>, IIParallelFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.IPEA;
        public override string Designation => "IPE A 300";
        public Length Height => new Length(297, LengthUnit.Millimeter);
        public Length Width => new Length(150, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(6.1, LengthUnit.Millimeter);
        public Length WebThickness => new Length(9.2, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(15, LengthUnit.Millimeter);

        public IPEA300() { }
    }
}

