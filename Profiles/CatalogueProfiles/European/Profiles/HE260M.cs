using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HE260M : SingletonEuropeanBase<HE260M>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.HEM;
        public override string Label => "HE 260 M";
        public Length Height => new Length(290, LengthUnit.Millimeter);
        public Length Width => new Length(268, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(32.5, LengthUnit.Millimeter);
        public Length WebThickness => new Length(18, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(24, LengthUnit.Millimeter);

        public HE260M() { }
    }
}
