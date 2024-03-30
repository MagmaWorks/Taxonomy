using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class IPE550 : SingletonEuropeanBase<IPE550>, IIParallelFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.IPE;
        public override string Designation => "IPE 550";
        public Length Height => new Length(550, LengthUnit.Millimeter);
        public Length Width => new Length(210, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(17.2, LengthUnit.Millimeter);
        public Length WebThickness => new Length(11.1, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(24, LengthUnit.Millimeter);

        public IPE550() { }
    }
}
