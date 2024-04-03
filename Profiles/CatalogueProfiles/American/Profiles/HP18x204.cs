using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HP18x204 : SingletonAmericanBase<HP18x204>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.HP;
        public override string Label => "HP18X204";
        public Length Height => new Length(18.30, LengthUnit.Inch);
        public Length Width => new Length(18.10, LengthUnit.Inch);
        public Length FlangeThickness => new Length(1.13, LengthUnit.Inch);
        public Length WebThickness => new Length(1.13, LengthUnit.Inch);
        public Length FilletRadius => new Length(1.185, LengthUnit.Inch);

        public HP18x204() { }
    }
}
