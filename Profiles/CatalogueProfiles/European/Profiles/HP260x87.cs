using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HP260x87 : SingletonEuropeanBase<HP260x87>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.HP;
        public override string Label => "HP 260 × 87";
        public Length Height => new Length(253, LengthUnit.Millimeter);
        public Length Width => new Length(267, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(14, LengthUnit.Millimeter);
        public Length WebThickness => new Length(14, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(24, LengthUnit.Millimeter);

        public HP260x87() { }
    }
}
