using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HP200x43 : SingletonEuropeanBase<HP200x43>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.HP;
        public override string Label => "HP 200 × 43";
        public Length Height => new Length(200, LengthUnit.Millimeter);
        public Length Width => new Length(205, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(9, LengthUnit.Millimeter);
        public Length WebThickness => new Length(9, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(10, LengthUnit.Millimeter);

        public HP200x43() { }
    }
}
