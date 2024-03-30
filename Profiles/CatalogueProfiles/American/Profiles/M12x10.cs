using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class M12x10 : SingletonAmericanBase<M12x10>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.M;
        public override string Label => "M12X10";
        public Length Height => new Length(12.00, LengthUnit.Inch);
        public Length Width => new Length(3.25, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.18, LengthUnit.Inch);
        public Length WebThickness => new Length(0.15, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.32, LengthUnit.Inch);

        public M12x10() { }
    }
}
