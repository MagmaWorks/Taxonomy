namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT4x33_5 : SingletonAmericanBase<WT4x33_5>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT4X33.5";
        public Length Height => new Length(4.50, LengthUnit.Inch);
        public Length Width => new Length(8.28, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.94, LengthUnit.Inch);
        public Length WebThickness => new Length(0.57, LengthUnit.Inch);
        public Length FilletRadius => new Length(3.17, LengthUnit.Inch);

        public WT4x33_5() { }
    }
}
