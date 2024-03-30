using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HD400x509 : SingletonEuropeanBase<HD400x509>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.HD;
        public override string Label => "HD 400 × 509";
        public Length Height => new Length(446, LengthUnit.Millimeter);
        public Length Width => new Length(416, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(62.7, LengthUnit.Millimeter);
        public Length WebThickness => new Length(39.1, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(15, LengthUnit.Millimeter);

        public HD400x509() { }
    }
}
