using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HD400x677 : SingletonEuropeanBase<HD400x677>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.HD;
        public override string Label => "HD 400 × 677";
        public Length Height => new Length(483, LengthUnit.Millimeter);
        public Length Width => new Length(428, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(81.5, LengthUnit.Millimeter);
        public Length WebThickness => new Length(51.2, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(15, LengthUnit.Millimeter);

        public HD400x677() { }
    }
}
