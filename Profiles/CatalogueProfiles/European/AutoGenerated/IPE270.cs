using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class IPE270 : SingletonEuropeanBase<IPE270>, IIParallelFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.IPE;
        public override string Designation => "IPE 270";
        public Length Height => new Length(270, LengthUnit.Millimeter);
        public Length Width => new Length(135, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(6.6, LengthUnit.Millimeter);
        public Length WebThickness => new Length(10.2, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(15, LengthUnit.Millimeter);

        public IPE270() { }
    }
}

