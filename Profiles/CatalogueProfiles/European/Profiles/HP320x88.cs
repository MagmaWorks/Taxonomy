namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HP320x88 : SingletonEuropeanBase<HP320x88>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.HP;
        public override string Label => "HP 320 × 88";
        public Length Height => new Length(303, LengthUnit.Millimeter);
        public Length Width => new Length(304, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(12, LengthUnit.Millimeter);
        public Length WebThickness => new Length(12, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(27, LengthUnit.Millimeter);

        public HP320x88() { }
    }
}
