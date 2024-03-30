using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class IPN425 : SingletonEuropeanBase<IPN425>, IITaperFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.IPN;
        public override string Designation => "IPN 425";
        public Length Height => new Length(425, LengthUnit.Millimeter);
        public Length Width => new Length(163, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(23, LengthUnit.Millimeter);
        public Length WebThickness => new Length(15.3, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(15.3, LengthUnit.Millimeter);
        public Length ToeRadius => new Length(9.2, LengthUnit.Millimeter);
        public Length WebHeight => new Length(343, LengthUnit.Millimeter);

        public IPN425() { }
    }
}
