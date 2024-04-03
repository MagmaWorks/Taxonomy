using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HD320x198 : SingletonEuropeanBase<HD320x198>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.HD;
        public override string Label => "HD 320 × 198";
        public Length Height => new Length(343, LengthUnit.Millimeter);
        public Length Width => new Length(306, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(32, LengthUnit.Millimeter);
        public Length WebThickness => new Length(18, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(27, LengthUnit.Millimeter);

        public HD320x198() { }
    }
}
