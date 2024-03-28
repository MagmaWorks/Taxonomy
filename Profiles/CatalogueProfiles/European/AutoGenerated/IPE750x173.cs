using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class IPE750x173 : SingletonEuropeanBase<IPE750x173>, IIParallelFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.IPE;
        public override string Designation => "IPE 750 × 173";
        public Length Height => new Length(762, LengthUnit.Millimeter);
        public Length Width => new Length(267, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(14.4, LengthUnit.Millimeter);
        public Length WebThickness => new Length(21.6, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(17, LengthUnit.Millimeter);

        public IPE750x173() { }
    }
}

