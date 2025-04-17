namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT15x58 : SingletonAmericanBase<WT15x58>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT15X58";
        public Length Height => new Length(15.00, LengthUnit.Inch);
        public Length Width => new Length(10.50, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.85, LengthUnit.Inch);
        public Length WebThickness => new Length(0.57, LengthUnit.Inch);
        public Length FilletRadius => new Length(13.5, LengthUnit.Inch);

        public WT15x58() { }
    }
}
