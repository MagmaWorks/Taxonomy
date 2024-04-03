using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class UB914x305x238 : SingletonEuropeanBase<UB914x305x238>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.UB;
        public override string Label => "UB 914 × 305 × 238";
        public Length Height => new Length(915, LengthUnit.Millimeter);
        public Length Width => new Length(305, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(25.9, LengthUnit.Millimeter);
        public Length WebThickness => new Length(16.5, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(19, LengthUnit.Millimeter);

        public UB914x305x238() { }
    }
}
