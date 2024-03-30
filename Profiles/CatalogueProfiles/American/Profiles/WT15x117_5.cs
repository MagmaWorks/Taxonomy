using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT15x117_5 : SingletonAmericanBase<WT15x117_5>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT15X117.5";
        public Length Height => new Length(15.70, LengthUnit.Inch);
        public Length Width => new Length(15.10, LengthUnit.Inch);
        public Length FlangeThickness => new Length(1.50, LengthUnit.Inch);
        public Length WebThickness => new Length(0.83, LengthUnit.Inch);
        public Length FilletRadius => new Length(4.845, LengthUnit.Inch);

        public WT15x117_5() { }
    }
}
