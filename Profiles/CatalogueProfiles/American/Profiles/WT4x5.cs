namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT4x5 : SingletonAmericanBase<WT4x5>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT4X5";
        public Length Height => new Length(3.95, LengthUnit.Inch);
        public Length Width => new Length(3.94, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.21, LengthUnit.Inch);
        public Length WebThickness => new Length(0.17, LengthUnit.Inch);
        public Length FilletRadius => new Length(3.44, LengthUnit.Inch);

        public WT4x5() { }
    }
}
