using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class C9x20 : SingletonAmericanBase<C9x20>, IChannelTaperFlange
    {
        public override AmericanShape Shape => AmericanShape.C;
        public override string Label => "C9X20";
        public Length Height => new Length(9.00, LengthUnit.Inch);
        public Length Width => new Length(2.65, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.41, LengthUnit.Inch);
        public Length WebThickness => new Length(0.45, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.59, LengthUnit.Inch);
        public Length ToeRadius => new Length(0.295, LengthUnit.Inch);
        public Length WebHeight => new Length(7.00, LengthUnit.Inch);

        public C9x20() { }
    }
}
