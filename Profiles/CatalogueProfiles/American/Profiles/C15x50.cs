using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class C15x50 : SingletonAmericanBase<C15x50>, IChannelTaperFlange
    {
        public override AmericanShape Shape => AmericanShape.C;
        public override string Label => "C15X50";
        public Length Height => new Length(15.00, LengthUnit.Inch);
        public Length Width => new Length(3.72, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.65, LengthUnit.Inch);
        public Length WebThickness => new Length(0.72, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.785, LengthUnit.Inch);
        public Length ToeRadius => new Length(0.392, LengthUnit.Inch);
        public Length WebHeight => new Length(12.13, LengthUnit.Inch);

        public C15x50() { }
    }
}
