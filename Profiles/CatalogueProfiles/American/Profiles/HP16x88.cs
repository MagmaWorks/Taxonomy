using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HP16x88 : SingletonAmericanBase<HP16x88>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.HP;
        public override string Label => "HP16X88";
        public Length Height => new Length(15.30, LengthUnit.Inch);
        public Length Width => new Length(15.70, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.54, LengthUnit.Inch);
        public Length WebThickness => new Length(0.54, LengthUnit.Inch);
        public Length FilletRadius => new Length(1.17, LengthUnit.Inch);

        public HP16x88() { }
    }
}
