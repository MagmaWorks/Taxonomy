using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class IPE220 : SingletonEuropeanBase<IPE220>, IIParallelFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.IPE;
        public override string Designation => "IPE 220";
        public Length Height => new Length(220, LengthUnit.Millimeter);
        public Length Width => new Length(110, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(5.9, LengthUnit.Millimeter);
        public Length WebThickness => new Length(9.2, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(12, LengthUnit.Millimeter);

        public IPE220() { }
    }
}

