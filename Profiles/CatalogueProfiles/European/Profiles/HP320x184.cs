namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HP320x184 : SingletonEuropeanBase<HP320x184>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.HP;
        public override string Label => "HP 320 × 184";
        public Length Height => new Length(329, LengthUnit.Millimeter);
        public Length Width => new Length(317, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(25, LengthUnit.Millimeter);
        public Length WebThickness => new Length(25, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(27, LengthUnit.Millimeter);

        public HP320x184() { }
    }
}
