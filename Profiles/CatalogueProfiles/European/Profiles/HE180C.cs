namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HE180C : SingletonEuropeanBase<HE180C>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.HEC;
        public override string Label => "HE 180 C";
        public Length Height => new Length(190, LengthUnit.Millimeter);
        public Length Width => new Length(183, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(19, LengthUnit.Millimeter);
        public Length WebThickness => new Length(11.5, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(15, LengthUnit.Millimeter);

        public HE180C() { }
    }
}
