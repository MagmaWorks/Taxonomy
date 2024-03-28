using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HP305x149 : SingletonEuropeanBase<HP305x149>, IIParallelFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.HP;
        public override string Designation => "HP 305 × 149";
        public Length Height => new Length(318.5, LengthUnit.Millimeter);
        public Length Width => new Length(316, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(20.6, LengthUnit.Millimeter);
        public Length WebThickness => new Length(20.7, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(15, LengthUnit.Millimeter);

        public HP305x149() { }
    }
}

