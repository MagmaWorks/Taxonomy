using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class M12_5x11_6 : SingletonAmericanBase<M12_5x11_6>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.M;
        public override string Label => "M12.5X11.6";
        public Length Height => new Length(12.50, LengthUnit.Inch);
        public Length Width => new Length(3.50, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.21, LengthUnit.Inch);
        public Length WebThickness => new Length(0.16, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.35, LengthUnit.Inch);

        public M12_5x11_6() { }
    }
}
