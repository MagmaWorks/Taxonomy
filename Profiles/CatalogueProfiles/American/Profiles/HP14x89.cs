using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HP14x89 : SingletonAmericanBase<HP14x89>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.HP;
        public override string Label => "HP14X89";
        public Length Height => new Length(13.80, LengthUnit.Inch);
        public Length Width => new Length(14.70, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.62, LengthUnit.Inch);
        public Length WebThickness => new Length(0.62, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.655, LengthUnit.Inch);

        public HP14x89() { }
    }
}
