using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class UC356x368x177 : SingletonEuropeanBase<UC356x368x177>, IIParallelFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.UC;
        public override string Designation => "UC 356 × 368 × 177";
        public Length Height => new Length(368.2, LengthUnit.Millimeter);
        public Length Width => new Length(372.6, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(14.4, LengthUnit.Millimeter);
        public Length WebThickness => new Length(23.8, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(15, LengthUnit.Millimeter);

        public UC356x368x177() { }
    }
}

