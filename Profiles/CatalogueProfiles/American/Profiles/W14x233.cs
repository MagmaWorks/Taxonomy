using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W14x233 : SingletonAmericanBase<W14x233>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W14X233";
        public Length Height => new Length(16.00, LengthUnit.Inch);
        public Length Width => new Length(15.90, LengthUnit.Inch);
        public Length FlangeThickness => new Length(1.72, LengthUnit.Inch);
        public Length WebThickness => new Length(1.07, LengthUnit.Inch);
        public Length FilletRadius => new Length(1.215, LengthUnit.Inch);

        public W14x233() { }
    }
}
