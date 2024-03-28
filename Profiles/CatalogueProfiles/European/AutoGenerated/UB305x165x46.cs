using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class UB305x165x46 : SingletonEuropeanBase<UB305x165x46>, IIParallelFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.UB;
        public override string Designation => "UB 305 × 165 × 46";
        public Length Height => new Length(306.6, LengthUnit.Millimeter);
        public Length Width => new Length(165.7, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(6.7, LengthUnit.Millimeter);
        public Length WebThickness => new Length(11.8, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(8.9, LengthUnit.Millimeter);

        public UB305x165x46() { }
    }
}

