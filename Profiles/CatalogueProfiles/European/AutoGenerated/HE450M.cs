using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HE450M : SingletonEuropeanBase<HE450M>, IIParallelFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.HEM;
        public override string Designation => "HE 450 M";
        public Length Height => new Length(478, LengthUnit.Millimeter);
        public Length Width => new Length(307, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(21, LengthUnit.Millimeter);
        public Length WebThickness => new Length(40, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(27, LengthUnit.Millimeter);

        public HE450M() { }
    }
}

