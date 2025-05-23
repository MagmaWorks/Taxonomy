namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HE200M : SingletonEuropeanBase<HE200M>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.HEM;
        public override string Label => "HE 200 M";
        public Length Height => new Length(220, LengthUnit.Millimeter);
        public Length Width => new Length(206, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(25, LengthUnit.Millimeter);
        public Length WebThickness => new Length(15, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(18, LengthUnit.Millimeter);

        public HE200M() { }
    }
}
