using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class IPE240 : SingletonEuropeanBase<IPE240>, IIParallelFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.IPE;
        public override string Designation => "IPE 240";
        public Length Height => new Length(240, LengthUnit.Millimeter);
        public Length Width => new Length(120, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(6.2, LengthUnit.Millimeter);
        public Length WebThickness => new Length(9.8, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(15, LengthUnit.Millimeter);

        public IPE240() { }
    }
}

