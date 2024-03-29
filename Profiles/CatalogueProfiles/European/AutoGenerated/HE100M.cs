using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HE100M : SingletonEuropeanBase<HE100M>, IIParallelFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.HEM;
        public override string Designation => "HE 100 M";
        public Length Height => new Length(120, LengthUnit.Millimeter);
        public Length Width => new Length(106, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(20, LengthUnit.Millimeter);
        public Length WebThickness => new Length(12, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(12, LengthUnit.Millimeter);

        public HE100M() { }
    }
}
