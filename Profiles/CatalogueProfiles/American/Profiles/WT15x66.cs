using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT15x66 : SingletonAmericanBase<WT15x66>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT15X66";
        public Length Height => new Length(15.20, LengthUnit.Inch);
        public Length Width => new Length(10.50, LengthUnit.Inch);
        public Length FlangeThickness => new Length(1.00, LengthUnit.Inch);
        public Length WebThickness => new Length(0.62, LengthUnit.Inch);
        public Length FilletRadius => new Length(3.29, LengthUnit.Inch);

        public WT15x66() { }
    }
}
