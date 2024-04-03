using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HP220x57 : SingletonEuropeanBase<HP220x57>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.HP;
        public override string Label => "HP 220 × 57";
        public Length Height => new Length(210, LengthUnit.Millimeter);
        public Length Width => new Length(224.5, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(11, LengthUnit.Millimeter);
        public Length WebThickness => new Length(11, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(18, LengthUnit.Millimeter);

        public HP220x57() { }
    }
}
