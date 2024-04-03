using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HD400x592 : SingletonEuropeanBase<HD400x592>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.HD;
        public override string Label => "HD 400 × 592";
        public Length Height => new Length(465, LengthUnit.Millimeter);
        public Length Width => new Length(421, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(72.3, LengthUnit.Millimeter);
        public Length WebThickness => new Length(45, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(15, LengthUnit.Millimeter);

        public HD400x592() { }
    }
}
