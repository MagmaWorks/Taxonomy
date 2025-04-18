namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class C7x14_75 : SingletonAmericanBase<C7x14_75>, IChannelTaperFlange
    {
        public override AmericanShape Shape => AmericanShape.C;
        public override string Label => "C7X14.75";
        public Length Height => new Length(7.00, LengthUnit.Inch);
        public Length Width => new Length(2.30, LengthUnit.Inch);
        public Length FlangeThickness => new Length(0.37, LengthUnit.Inch);
        public Length WebThickness => new Length(0.42, LengthUnit.Inch);
        public Length FilletRadius => new Length(0.505, LengthUnit.Inch);
        public Length ToeRadius => new Length(0.252, LengthUnit.Inch);
        public Length WebHeight => new Length(5.25, LengthUnit.Inch);

        public C7x14_75() { }
    }
}
