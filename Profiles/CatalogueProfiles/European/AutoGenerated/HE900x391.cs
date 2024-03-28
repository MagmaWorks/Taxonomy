using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HE900x391 : SingletonEuropeanBase<HE900x391>, IIParallelFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.HE;
        public override string Designation => "HE 900 × 391";
        public Length Height => new Length(922, LengthUnit.Millimeter);
        public Length Width => new Length(307, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(25, LengthUnit.Millimeter);
        public Length WebThickness => new Length(46, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(30, LengthUnit.Millimeter);

        public HE900x391() { }
    }
}

