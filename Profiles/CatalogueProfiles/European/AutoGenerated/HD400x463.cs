using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HD400x463 : SingletonEuropeanBase<HD400x463>, IIParallelFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.HD;
        public override string Designation => "HD 400 × 463";
        public Length Height => new Length(435, LengthUnit.Millimeter);
        public Length Width => new Length(412, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(35.8, LengthUnit.Millimeter);
        public Length WebThickness => new Length(57.4, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(15, LengthUnit.Millimeter);

        public HD400x463() { }
    }
}

