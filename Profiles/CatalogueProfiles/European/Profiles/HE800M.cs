namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HE800M : SingletonEuropeanBase<HE800M>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.HEM;
        public override string Label => "HE 800 M";
        public Length Height => new Length(814, LengthUnit.Millimeter);
        public Length Width => new Length(303, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(40, LengthUnit.Millimeter);
        public Length WebThickness => new Length(21, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(30, LengthUnit.Millimeter);

        public HE800M() { }
    }
}
