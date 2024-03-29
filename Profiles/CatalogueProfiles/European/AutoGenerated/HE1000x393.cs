using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HE1000x393 : SingletonEuropeanBase<HE1000x393>, IIParallelFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.HE;
        public override string Designation => "HE 1000 × 393";
        public Length Height => new Length(1016, LengthUnit.Millimeter);
        public Length Width => new Length(303, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(43.9, LengthUnit.Millimeter);
        public Length WebThickness => new Length(24.4, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(30, LengthUnit.Millimeter);

        public HE1000x393() { }
    }
}
