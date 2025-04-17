namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT22x115 : SingletonAmericanBase<WT22x115>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT22X115";
        public Length Height => new Length(21.50, LengthUnit.Inch);
        public Length Width => new Length(15.80, LengthUnit.Inch);
        public Length FlangeThickness => new Length(1.22, LengthUnit.Inch);
        public Length WebThickness => new Length(0.71, LengthUnit.Inch);
        public Length FilletRadius => new Length(19.49, LengthUnit.Inch);

        public WT22x115() { }
    }
}
