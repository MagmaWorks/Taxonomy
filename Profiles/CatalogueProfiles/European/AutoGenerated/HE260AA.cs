using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HE260AA : SingletonEuropeanBase<HE260AA>, IIParallelFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.HEAA;
        public override string Designation => "HE 260 AA";
        public Length Height => new Length(244, LengthUnit.Millimeter);
        public Length Width => new Length(260, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(6.5, LengthUnit.Millimeter);
        public Length WebThickness => new Length(9.5, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(24, LengthUnit.Millimeter);

        public HE260AA() { }
    }
}

