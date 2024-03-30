using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HD320x74_2 : SingletonEuropeanBase<HD320x74_2>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.HD;
        public override string Label => "HD 320 × 74,2";
        public Length Height => new Length(301, LengthUnit.Millimeter);
        public Length Width => new Length(300, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(11, LengthUnit.Millimeter);
        public Length WebThickness => new Length(8, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(27, LengthUnit.Millimeter);

        public HD320x74_2() { }
    }
}
