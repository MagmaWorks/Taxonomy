using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class IPE120 : SingletonEuropeanBase<IPE120>, IIParallelFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.IPE;
        public override string Designation => "IPE 120";
        public Length Height => new Length(120, LengthUnit.Millimeter);
        public Length Width => new Length(64, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(4.4, LengthUnit.Millimeter);
        public Length WebThickness => new Length(6.3, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(7, LengthUnit.Millimeter);

        public IPE120() { }
    }
}

