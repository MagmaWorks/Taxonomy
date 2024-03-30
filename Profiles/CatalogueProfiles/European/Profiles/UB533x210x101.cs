using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class UB533x210x101 : SingletonEuropeanBase<UB533x210x101>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.UB;
        public override string Label => "UB 533 × 210 × 101";
        public Length Height => new Length(536.7, LengthUnit.Millimeter);
        public Length Width => new Length(210, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(17.4, LengthUnit.Millimeter);
        public Length WebThickness => new Length(10.8, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(13, LengthUnit.Millimeter);

        public UB533x210x101() { }
    }
}
