using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HP8x36 : SingletonAmericanBase<HP8x36>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.HP;
        public override string Label => "HP8X36";
        public Length Height => new Length(8.02, LengthUnit.Inch);
        public Length Width => new Length(8.16, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.45, LengthUnit.Inch);
        public Length WebThickness => new Length(0.45, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.655, LengthUnit.Inch);

        public HP8x36() { }
    }
}
