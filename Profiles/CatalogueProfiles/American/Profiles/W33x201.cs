using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class W33x201 : SingletonAmericanBase<W33x201>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.W;
        public override string Label => "W33X201";
        public Length Height => new Length(33.70, LengthUnit.Inch);
        public Length Width => new Length(15.70, LengthUnit.Inch);
        public Length FlangeThickness => new Length(1.15, LengthUnit.Inch);
        public Length WebThickness => new Length(0.72, LengthUnit.Inch);
        public Length FilletRadius => new Length(1.26, LengthUnit.Inch);

        public W33x201() { }
    }
}
