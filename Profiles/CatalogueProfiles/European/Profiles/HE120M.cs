namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HE120M : SingletonEuropeanBase<HE120M>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.HEM;
        public override string Label => "HE 120 M";
        public Length Height => new Length(140, LengthUnit.Millimeter);
        public Length Width => new Length(126, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(21, LengthUnit.Millimeter);
        public Length WebThickness => new Length(12.5, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(12, LengthUnit.Millimeter);

        public HE120M() { }
    }
}
