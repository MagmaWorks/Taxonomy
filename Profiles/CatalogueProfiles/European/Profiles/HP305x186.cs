namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HP305x186 : SingletonEuropeanBase<HP305x186>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.HP;
        public override string Label => "HP 305 × 186";
        public Length Height => new Length(328.3, LengthUnit.Millimeter);
        public Length Width => new Length(320.9, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(25.6, LengthUnit.Millimeter);
        public Length WebThickness => new Length(25.5, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(15, LengthUnit.Millimeter);

        public HP305x186() { }
    }
}
