using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class IPEAA100 : SingletonEuropeanBase<IPEAA100>, IIParallelFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.IPEAA;
        public override string Designation => "IPE AA 100";
        public Length Height => new Length(97.6, LengthUnit.Millimeter);
        public Length Width => new Length(55, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(4.5, LengthUnit.Millimeter);
        public Length WebThickness => new Length(3.6, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(7, LengthUnit.Millimeter);

        public IPEAA100() { }
    }
}
