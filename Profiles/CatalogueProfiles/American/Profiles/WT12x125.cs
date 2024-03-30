using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT12x125 : SingletonAmericanBase<WT12x125>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT12X125";
        public Length Height => new Length(13.20, LengthUnit.Inch);
        public Length Width => new Length(13.20, LengthUnit.Inch);
        public Length FlangeThickness => new Length(1.89, LengthUnit.Inch);
        public Length WebThickness => new Length(1.04, LengthUnit.Inch);
        public Length FilletRadius => new Length(3.69, LengthUnit.Inch);

        public WT12x125() { }
    }
}
