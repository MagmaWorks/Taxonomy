namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class WT7x155_5 : SingletonAmericanBase<WT7x155_5>, ICutTeeParallelFlange
    {
        public override AmericanShape Shape => AmericanShape.WT;
        public override string Label => "WT7X155.5";
        public Length Height => new Length(8.56, LengthUnit.Inch);
        public Length Width => new Length(16.20, LengthUnit.Inch);
        public Length FlangeThickness => new Length(2.26, LengthUnit.Inch);
        public Length WebThickness => new Length(1.41, LengthUnit.Inch);
        public Length FilletRadius => new Length(5.7, LengthUnit.Inch);

        public WT7x155_5() { }
    }
}
