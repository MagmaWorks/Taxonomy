using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class IPN550 : SingletonEuropeanBase<IPN550>, IITaperFlange
    {
        public override EuropeanShapeType ShapeType => EuropeanShapeType.IPN;
        public override string Designation => "IPN 550";
        public Length Height => new Length(550, LengthUnit.Millimeter);
        public Length Width => new Length(200, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(19, LengthUnit.Millimeter);
        public Length WebThickness => new Length(30, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(19, LengthUnit.Millimeter);
        public Length ToeRadius => new Length(11.4, LengthUnit.Millimeter);
        public Length WebHeight => new Length(445, LengthUnit.Millimeter);

        public IPN550() { }
    }
}

