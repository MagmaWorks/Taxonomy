namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT22x167_5 : SingletonAmericanBase<WT22x167_5>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT22X167.5";
        public Length Height => new Length(22.00, LengthUnit.Inch);
        public Length Width => new Length(15.90, LengthUnit.Inch);
        public Length FlangeThickness => new Length(1.77, LengthUnit.Inch);
        public Length WebThickness => new Length(1.03, LengthUnit.Inch);
        public Length FilletRadius => new Length(19.44, LengthUnit.Inch);

        public WT22x167_5() { }
    }
}
