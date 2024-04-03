using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HD260x68_2 : SingletonEuropeanBase<HD260x68_2>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.HD;
        public override string Label => "HD 260 × 68,2";
        public Length Height => new Length(250, LengthUnit.Millimeter);
        public Length Width => new Length(260, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(12.5, LengthUnit.Millimeter);
        public Length WebThickness => new Length(7.5, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(24, LengthUnit.Millimeter);

        public HD260x68_2() { }
    }
}
