using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class ST6x17_5 : SingletonAmericanBase<ST6x17_5>, ICutTeeTaperFlange
    {
        public override AmericanShape Shape => AmericanShape.ST;
        public override string Label => "ST6X17.5";
        public Length Height => new Length(6.00, LengthUnit.Inch);
        public Length Width => new Length(5.08, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.54, LengthUnit.Inch);
        public Length WebThickness => new Length(0.43, LengthUnit.Inch);
        public Length FilletRadius => new Length(1.135, LengthUnit.Inch);
        public Length ToeRadius => new Length(0.568, LengthUnit.Inch);

        public ST6x17_5() { }
    }
}
