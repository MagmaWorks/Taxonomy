namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HE320C : SingletonEuropeanBase<HE320C>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.HEC;
        public override string Label => "HE 320 C";
        public Length Height => new Length(340, LengthUnit.Millimeter);
        public Length Width => new Length(305, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(30.5, LengthUnit.Millimeter);
        public Length WebThickness => new Length(16, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(27, LengthUnit.Millimeter);

        public HE320C() { }
    }
}
