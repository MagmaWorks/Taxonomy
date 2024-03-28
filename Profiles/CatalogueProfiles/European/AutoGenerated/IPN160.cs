using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class IPN160 : SingletonEuropeanBase<IPN160>, IITaperFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.IPN;
        public override string Designation => "IPN 160";
        public Length Height => new Length(160, LengthUnit.Millimeter);
        public Length Width => new Length(74, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(6.3, LengthUnit.Millimeter);
        public Length WebThickness => new Length(9.5, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(6.3, LengthUnit.Millimeter);
        public Length ToeRadius => new Length(3.8, LengthUnit.Millimeter);
        public Length WebHeight => new Length(125, LengthUnit.Millimeter);

        public IPN160() { }
    }
}

