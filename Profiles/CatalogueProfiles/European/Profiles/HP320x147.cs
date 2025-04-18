namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HP320x147 : SingletonEuropeanBase<HP320x147>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.HP;
        public override string Label => "HP 320 × 147";
        public Length Height => new Length(319, LengthUnit.Millimeter);
        public Length Width => new Length(312, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(20, LengthUnit.Millimeter);
        public Length WebThickness => new Length(20, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(27, LengthUnit.Millimeter);

        public HP320x147() { }
    }
}
