using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class UB533x210x82 : SingletonEuropeanBase<UB533x210x82>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.UB;
        public override string Label => "UB 533 × 210 × 82";
        public Length Height => new Length(528.3, LengthUnit.Millimeter);
        public Length Width => new Length(208.8, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(13.2, LengthUnit.Millimeter);
        public Length WebThickness => new Length(9.6, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(13, LengthUnit.Millimeter);

        public UB533x210x82() { }
    }
}
