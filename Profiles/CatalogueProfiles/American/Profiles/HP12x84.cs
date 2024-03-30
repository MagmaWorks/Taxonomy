using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HP12x84 : SingletonAmericanBase<HP12x84>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.HP;
        public override string Label => "HP12X84";
        public Length Height => new Length(12.30, LengthUnit.Inch);
        public Length Width => new Length(12.30, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.69, LengthUnit.Inch);
        public Length WebThickness => new Length(0.69, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.71, LengthUnit.Inch);

        public HP12x84() { }
    }
}
