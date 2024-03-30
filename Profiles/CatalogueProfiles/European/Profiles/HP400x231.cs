using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HP400x231 : SingletonEuropeanBase<HP400x231>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.HP;
        public override string Label => "HP 400 × 231";
        public Length Height => new Length(372, LengthUnit.Millimeter);
        public Length Width => new Length(402, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(26, LengthUnit.Millimeter);
        public Length WebThickness => new Length(26, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(15.2, LengthUnit.Millimeter);

        public HP400x231() { }
    }
}
