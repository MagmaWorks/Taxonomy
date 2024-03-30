using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HE800x444 : SingletonEuropeanBase<HE800x444>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.HE;
        public override string Label => "HE 800 × 444";
        public Length Height => new Length(842, LengthUnit.Millimeter);
        public Length Width => new Length(313, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(54, LengthUnit.Millimeter);
        public Length WebThickness => new Length(30, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(30, LengthUnit.Millimeter);

        public HE800x444() { }
    }
}
