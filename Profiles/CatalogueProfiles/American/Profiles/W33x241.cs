using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W33x241 : SingletonAmericanBase<W33x241>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W33X241";
        public Length Height => new Length(34.20, LengthUnit.Inch);
        public Length Width => new Length(15.90, LengthUnit.Inch);
        public Length FlangeThickness => new Length(1.40, LengthUnit.Inch);
        public Length WebThickness => new Length(0.83, LengthUnit.Inch);
        public Length FilletRadius => new Length(1.215, LengthUnit.Inch);

        public W33x241() { }
    }
}
