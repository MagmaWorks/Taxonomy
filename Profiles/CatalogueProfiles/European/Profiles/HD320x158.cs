namespace MagmaWorks.Taxonomy.Profiles
{
    public sealed class HD320x158 : SingletonEuropeanBase<HD320x158>, IIParallelFlange
    {
        public override EuropeanShape Shape => EuropeanShape.HD;
        public override string Label => "HD 320 × 158";
        public Length Height => new Length(330, LengthUnit.Millimeter);
        public Length Width => new Length(303, LengthUnit.Millimeter);
        public Length FlangeThickness => new Length(25.5, LengthUnit.Millimeter);
        public Length WebThickness => new Length(14.5, LengthUnit.Millimeter);
        public Length FilletRadius => new Length(27, LengthUnit.Millimeter);

        public HD320x158() { }
    }
}
