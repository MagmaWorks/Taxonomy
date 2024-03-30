using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class IPEAA120 : SingletonEuropeanBase<IPEAA120>, IIParallelFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.IPEAA;
        public override string Designation => "IPE AA 120";
        public Length Height => new Length(117, LengthUnit.Millimeter);
        public Length Width => new Length(64, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(4.8, LengthUnit.Millimeter);
        public Length WebThickness => new Length(3.8, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(7, LengthUnit.Millimeter);

        public IPEAA120() { }
    }
}
