using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HL1100M : SingletonEuropeanBase<HL1100M>, IIParallelFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.HL;
        public override string Designation => "HL 1100 M";
        public Length Height => new Length(1108, LengthUnit.Millimeter);
        public Length Width => new Length(402, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(22, LengthUnit.Millimeter);
        public Length WebThickness => new Length(40, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(30, LengthUnit.Millimeter);

        public HL1100M() { }
    }
}

