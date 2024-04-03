using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HD360x147 : SingletonEuropeanBase<HD360x147>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.HD;
        public override string Label => "HD 360 × 147";
        public Length Height => new Length(360, LengthUnit.Millimeter);
        public Length Width => new Length(370, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(19.8, LengthUnit.Millimeter);
        public Length WebThickness => new Length(12.3, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(15, LengthUnit.Millimeter);

        public HD360x147() { }
    }
}
