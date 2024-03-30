using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HP12x63 : SingletonAmericanBase<HP12x63>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.HP;
        public override string Label => "HP12X63";
        public Length Height => new Length(11.90, LengthUnit.Inch);
        public Length Width => new Length(12.10, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.52, LengthUnit.Inch);
        public Length WebThickness => new Length(0.52, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.68, LengthUnit.Inch);

        public HP12x63() { }
    }
}
