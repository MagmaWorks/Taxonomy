namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HP360x133 : SingletonEuropeanBase<HP360x133>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.HP;
        public override string Label => "HP 360 × 133";
        public Length Height => new Length(352, LengthUnit.Millimeter);
        public Length Width => new Length(373.8, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(15.7, LengthUnit.Millimeter);
        public Length WebThickness => new Length(15.6, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(15, LengthUnit.Millimeter);

        public HP360x133() { }
    }
}
