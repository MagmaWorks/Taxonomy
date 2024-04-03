using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class C10x25 : SingletonAmericanBase<C10x25>, IChannelTaperFlange
    {
        public override AmericanShape Shape => AmericanShape.C;
        public override string Label => "C10X25";
        public Length Height => new Length(10.00, LengthUnit.Inch);
        public Length Width => new Length(2.89, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.44, LengthUnit.Inch);
        public Length WebThickness => new Length(0.53, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.56, LengthUnit.Inch);
        public Length ToeRadius => new Length(0.28, LengthUnit.Inch);
        public Length WebHeight => new Length(8.00, LengthUnit.Inch);

        public C10x25() { }
    }
}
