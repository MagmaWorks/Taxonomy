namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT6x20 : SingletonAmericanBase<WT6x20>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT6X20";
        public Length Height => new Length(5.97, LengthUnit.Inch);
        public Length Width => new Length(8.01, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.52, LengthUnit.Inch);
        public Length WebThickness => new Length(0.30, LengthUnit.Inch);
        public Length FilletRadius => new Length(4.95, LengthUnit.Inch);

        public WT6x20() { }
    }
}
