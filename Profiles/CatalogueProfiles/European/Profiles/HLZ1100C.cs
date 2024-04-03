using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HLZ1100C : SingletonEuropeanBase<HLZ1100C>, IITaperFlange
    {
        public override EuropeanShape Shape => EuropeanShape.HLZ;
        public override string Label => "HLZ 1100 C";
        public Length Height => new Length(1083.4, LengthUnit.Millimeter);
        public Length Width => new Length(459, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(35, LengthUnit.Millimeter);
        public Length WebThickness => new Length(21, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(35, LengthUnit.Millimeter);
        public Length ToeRadius => new Length(0, LengthUnit.Millimeter);
        public Length WebHeight => new Length(935.9, LengthUnit.Millimeter);

        public HLZ1100C() { }
    }
}
