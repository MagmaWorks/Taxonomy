using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class IPE450 : SingletonEuropeanBase<IPE450>, IIParallelFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.IPE;
        public override string Designation => "IPE 450";
        public Length Height => new Length(450, LengthUnit.Millimeter);
        public Length Width => new Length(190, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(9.4, LengthUnit.Millimeter);
        public Length WebThickness => new Length(14.6, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(21, LengthUnit.Millimeter);

        public IPE450() { }
    }
}

