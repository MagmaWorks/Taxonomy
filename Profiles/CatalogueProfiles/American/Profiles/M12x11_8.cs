using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class M12x11_8 : SingletonAmericanBase<M12x11_8>, IIParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.M;
        public override string Label => "M12X11.8";
        public Length Height => new Length(12.00, LengthUnit.Inch);
        public Length Width => new Length(3.07, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.23, LengthUnit.Inch);
        public Length WebThickness => new Length(0.18, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.33, LengthUnit.Inch);

        public M12x11_8() { }
    }
}
