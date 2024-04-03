using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HP18x157 : SingletonAmericanBase<HP18x157>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.HP;
        public override string Label => "HP18X157";
        public Length Height => new Length(17.70, LengthUnit.Inch);
        public Length Width => new Length(17.90, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.87, LengthUnit.Inch);
        public Length WebThickness => new Length(0.87, LengthUnit.Inch);
        public Length FilletRadius => new Length(1.195, LengthUnit.Inch);

        public HP18x157() { }
    }
}
