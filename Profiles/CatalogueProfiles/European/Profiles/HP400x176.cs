using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HP400x176 : SingletonEuropeanBase<HP400x176>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.HP;
        public override string Label => "HP 400 × 176";
        public Length Height => new Length(360, LengthUnit.Millimeter);
        public Length Width => new Length(396, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(20, LengthUnit.Millimeter);
        public Length WebThickness => new Length(20, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(15.2, LengthUnit.Millimeter);

        public HP400x176() { }
    }
}
