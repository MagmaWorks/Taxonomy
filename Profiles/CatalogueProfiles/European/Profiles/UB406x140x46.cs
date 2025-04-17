namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class UB406x140x46 : SingletonEuropeanBase<UB406x140x46>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.UB;
        public override string Label => "UB 406 × 140 × 46";
        public Length Height => new Length(403.2, LengthUnit.Millimeter);
        public Length Width => new Length(142.2, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(11.2, LengthUnit.Millimeter);
        public Length WebThickness => new Length(6.8, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(10, LengthUnit.Millimeter);

        public UB406x140x46() { }
    }
}
