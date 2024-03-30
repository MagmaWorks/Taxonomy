using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HP16x121 : SingletonAmericanBase<HP16x121>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.HP;
        public override string Label => "HP16X121";
        public Length Height => new Length(15.80, LengthUnit.Inch);
        public Length Width => new Length(15.90, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.75, LengthUnit.Inch);
        public Length WebThickness => new Length(0.75, LengthUnit.Inch);
        public Length FilletRadius => new Length(1.275, LengthUnit.Inch);

        public HP16x121() { }
    }
}
