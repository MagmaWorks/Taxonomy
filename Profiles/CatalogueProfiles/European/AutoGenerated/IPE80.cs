using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class IPE80 : SingletonEuropeanBase<IPE80>, IIParallelFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.IPE;
        public override string Designation => "IPE 80";
        public Length Height => new Length(80, LengthUnit.Millimeter);
        public Length Width => new Length(46, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(3.8, LengthUnit.Millimeter);
        public Length WebThickness => new Length(5.2, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(5, LengthUnit.Millimeter);

        public IPE80() { }
    }
}

