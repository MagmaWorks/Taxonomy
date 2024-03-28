using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HE140M : SingletonEuropeanBase<HE140M>, IIParallelFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.HEM;
        public override string Designation => "HE 140 M";
        public Length Height => new Length(160, LengthUnit.Millimeter);
        public Length Width => new Length(146, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(22, LengthUnit.Millimeter);
        public Length WebThickness => new Length(13, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(12, LengthUnit.Millimeter);

        public HE140M() { }
    }
}

