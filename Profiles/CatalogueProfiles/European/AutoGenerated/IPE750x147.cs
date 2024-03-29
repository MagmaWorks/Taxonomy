using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class IPE750x147 : SingletonEuropeanBase<IPE750x147>, IIParallelFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.IPE;
        public override string Designation => "IPE 750 × 147";
        public Length Height => new Length(753, LengthUnit.Millimeter);
        public Length Width => new Length(265, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(17, LengthUnit.Millimeter);
        public Length WebThickness => new Length(13.2, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(17, LengthUnit.Millimeter);

        public IPE750x147() { }
    }
}
