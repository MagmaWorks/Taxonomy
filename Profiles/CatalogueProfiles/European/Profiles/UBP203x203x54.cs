using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class UBP203x203x54 : SingletonEuropeanBase<UBP203x203x54>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.UBP;
        public override string Label => "UBP 203 × 203 × 54";
        public Length Height => new Length(204, LengthUnit.Millimeter);
        public Length Width => new Length(207.7, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(11.4, LengthUnit.Millimeter);
        public Length WebThickness => new Length(11.3, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(10, LengthUnit.Millimeter);

        public UBP203x203x54() { }
    }
}
