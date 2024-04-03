using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HP12x74 : SingletonAmericanBase<HP12x74>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.HP;
        public override string Label => "HP12X74";
        public Length Height => new Length(12.10, LengthUnit.Inch);
        public Length Width => new Length(12.20, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.61, LengthUnit.Inch);
        public Length WebThickness => new Length(0.61, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.825, LengthUnit.Inch);

        public HP12x74() { }
    }
}
