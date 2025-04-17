namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT15x130_5 : SingletonAmericanBase<WT15x130_5>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT15X130.5";
        public Length Height => new Length(15.80, LengthUnit.Inch);
        public Length Width => new Length(15.20, LengthUnit.Inch);
        public Length FlangeThickness => new Length(1.65, LengthUnit.Inch);
        public Length WebThickness => new Length(0.93, LengthUnit.Inch);
        public Length FilletRadius => new Length(13.36, LengthUnit.Inch);

        public WT15x130_5() { }
    }
}
