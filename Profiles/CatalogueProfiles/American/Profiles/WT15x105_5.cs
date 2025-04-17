namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT15x105_5 : SingletonAmericanBase<WT15x105_5>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT15X105.5";
        public Length Height => new Length(15.50, LengthUnit.Inch);
        public Length Width => new Length(15.10, LengthUnit.Inch);
        public Length FlangeThickness => new Length(1.32, LengthUnit.Inch);
        public Length WebThickness => new Length(0.78, LengthUnit.Inch);
        public Length FilletRadius => new Length(13.4, LengthUnit.Inch);

        public WT15x105_5() { }
    }
}
