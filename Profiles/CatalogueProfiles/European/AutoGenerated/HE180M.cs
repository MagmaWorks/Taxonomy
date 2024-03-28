using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HE180M : SingletonEuropeanBase<HE180M>, IIParallelFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.HEM;
        public override string Designation => "HE 180 M";
        public Length Height => new Length(200, LengthUnit.Millimeter);
        public Length Width => new Length(186, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(14.5, LengthUnit.Millimeter);
        public Length WebThickness => new Length(24, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(18, LengthUnit.Millimeter);

        public HE180M() { }
    }
}

