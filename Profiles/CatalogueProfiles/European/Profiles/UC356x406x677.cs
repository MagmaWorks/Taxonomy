using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class UC356x406x677 : SingletonEuropeanBase<UC356x406x677>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.UC;
        public override string Label => "UC 356 × 406 × 677";
        public Length Height => new Length(483, LengthUnit.Millimeter);
        public Length Width => new Length(428, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(81.5, LengthUnit.Millimeter);
        public Length WebThickness => new Length(51.2, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(15, LengthUnit.Millimeter);

        public UC356x406x677() { }
    }
}
