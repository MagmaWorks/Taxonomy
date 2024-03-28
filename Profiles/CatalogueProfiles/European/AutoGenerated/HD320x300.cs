using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HD320x300 : SingletonEuropeanBase<HD320x300>, IIParallelFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.HD;
        public override string Designation => "HD 320 × 300";
        public Length Height => new Length(375, LengthUnit.Millimeter);
        public Length Width => new Length(313, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(48, LengthUnit.Millimeter);
        public Length WebThickness => new Length(27, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(27, LengthUnit.Millimeter);

        public HD320x300() { }
    }
}

