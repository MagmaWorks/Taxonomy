namespace MagmaWorks.Taxonomy.Profiles.PerimeterFactory
{
    public static partial class PerimeterFactory
    {
        public static IPerimeter CreatePerimeter(IProfile profile)
        {
            if (profile is IPerimeter perimeter)
            {
                return perimeter;
            }

            int divisions = 8;
            Length tolerance = new Length(10, LengthUnit.Millimeter);
            Length diameter = Length.Zero;
            switch (profile)
            {
                case IAngle angle:
                    return CreateAngle(angle);

                case IC c:
                    return CreateC(c);

                case IChannel channel:
                    return CreateChannel(channel);

                case ICircularHollow circularHollow:
                    divisions = PerimeterFactoryUtility.CalculateDivisions(circularHollow.Diameter / 2, tolerance);
                    return CreateCircularHollow(circularHollow, divisions * 2);

                case ICircle circle:
                    divisions = PerimeterFactoryUtility.CalculateDivisions(circle.Diameter / 2, tolerance);
                    return CreateCircle(circle, divisions * 2);

                case ICruciform cruciform:
                    return CreateCruciform(cruciform);

                case ICustomI customI:
                    return CreateCustomI(customI);

                case IEllipseHollow ellipseHollow:
                    diameter = ellipseHollow.Height > ellipseHollow.Width ? ellipseHollow.Height : ellipseHollow.Width;
                    divisions = PerimeterFactoryUtility.CalculateDivisions(diameter / 2, tolerance);
                    return CreateEllipseHollow(ellipseHollow, divisions * 2);

                case IEllipse ellipse:
                    diameter = ellipse.Height > ellipse.Width ? ellipse.Height : ellipse.Width;
                    divisions = PerimeterFactoryUtility.CalculateDivisions(diameter / 2, tolerance);
                    return CreateEllipse(ellipse, divisions * 2);

                case IIParallelFlange parallelFlange:
                    divisions = PerimeterFactoryUtility.CalculateDivisions(parallelFlange.FilletRadius / 2, tolerance);
                    return CreateParallelFlange(parallelFlange, divisions);

                case II i:
                    return CreateI(i);

                case IRectangularHollow rectangularHollow:
                    return CreateRectangularHollow(rectangularHollow);

                case IRoundedRectangularHollow roundedRectangularHollow:
                    diameter = (roundedRectangularHollow.Height - roundedRectangularHollow.FlatHeight) >
                        (roundedRectangularHollow.Width - roundedRectangularHollow.FlatWidth)
                        ? (roundedRectangularHollow.Height - roundedRectangularHollow.FlatHeight)
                        : (roundedRectangularHollow.Width - roundedRectangularHollow.FlatWidth);
                    divisions = PerimeterFactoryUtility.CalculateDivisions(diameter / 4, tolerance);
                    return CreateRoundedRectangularHollow(roundedRectangularHollow, divisions);

                case IRoundedRectangle roundedRectangle:
                    diameter = (roundedRectangle.Height - roundedRectangle.FlatHeight) > (roundedRectangle.Width - roundedRectangle.FlatWidth)
                        ? (roundedRectangle.Height - roundedRectangle.FlatHeight) : (roundedRectangle.Width - roundedRectangle.FlatWidth);
                    divisions = PerimeterFactoryUtility.CalculateDivisions(diameter / 4, tolerance);
                    return CreateRoundedRectangle(roundedRectangle, divisions);

                case IRectangle rectangle:
                    return CreateRectangle(rectangle);

                case ITee tee:
                    return CreateTee(tee);

                case ITrapezoid trapezoid:
                    return CreateTrapezoid(trapezoid);

                case IZ z:
                    return CreateZ(z);

                default: throw new ArgumentException($"Unable to convert type {profile.GetType().Name} to IPerimeter");
            }
        }

        internal static IPerimeter CreatePerimeter(IProfile profile, Length tolerance)
        {
            int divisions = 8;
            Length diameter = Length.Zero;
            switch (profile)
            {
                case IAngle angle:
                    return CreateAngle(angle);

                case IC c:
                    return CreateC(c);

                case IChannel channel:
                    return CreateChannel(channel);

                case ICircularHollow circularHollow:
                    divisions = PerimeterFactoryUtility.CalculateDivisions(circularHollow.Diameter / 2, tolerance);
                    return CreateCircularHollow(circularHollow, divisions * 2);

                case ICircle circle:
                    divisions = PerimeterFactoryUtility.CalculateDivisions(circle.Diameter / 2, tolerance);
                    return CreateCircle(circle, divisions * 2);

                case ICruciform cruciform:
                    return CreateCruciform(cruciform);

                case ICustomI customI:
                    return CreateCustomI(customI);


                case IEllipseHollow ellipseHollow:
                    diameter = ellipseHollow.Height > ellipseHollow.Width ? ellipseHollow.Height : ellipseHollow.Width;
                    divisions = PerimeterFactoryUtility.CalculateDivisions(diameter / 2, tolerance);
                    return CreateEllipseHollow(ellipseHollow, divisions);

                case IEllipse ellipse:
                    diameter = ellipse.Height > ellipse.Width ? ellipse.Height : ellipse.Width;
                    divisions = PerimeterFactoryUtility.CalculateDivisions(diameter / 2, tolerance);
                    return CreateEllipse(ellipse, divisions);

                case IIParallelFlange parallelFlange:
                    divisions = PerimeterFactoryUtility.CalculateDivisions(parallelFlange.FilletRadius / 2, tolerance);
                    return CreateParallelFlange(parallelFlange, divisions);

                case II i:
                    return CreateI(i);

                case IRectangularHollow rectangularHollow:
                    return CreateRectangularHollow(rectangularHollow);

                case IRoundedRectangularHollow roundedRectangularHollow:
                    diameter = (roundedRectangularHollow.Height - roundedRectangularHollow.FlatHeight) >
                        (roundedRectangularHollow.Width - roundedRectangularHollow.FlatWidth)
                        ? (roundedRectangularHollow.Height - roundedRectangularHollow.FlatHeight)
                        : (roundedRectangularHollow.Width - roundedRectangularHollow.FlatWidth);
                    divisions = PerimeterFactoryUtility.CalculateDivisions(diameter / 2, tolerance);
                    return CreateRoundedRectangularHollow(roundedRectangularHollow, divisions);

                case IRoundedRectangle roundedRectangle:
                    diameter = (roundedRectangle.Height - roundedRectangle.FlatHeight) > (roundedRectangle.Width - roundedRectangle.FlatWidth)
                        ? (roundedRectangle.Height - roundedRectangle.FlatHeight) : (roundedRectangle.Width - roundedRectangle.FlatWidth);
                    divisions = PerimeterFactoryUtility.CalculateDivisions(diameter / 2, tolerance);
                    return CreateRoundedRectangle(roundedRectangle, divisions);

                case IRectangle rectangle:
                    return CreateRectangle(rectangle);

                case ITee tee:
                    return CreateTee(tee);

                case ITrapezoid trapezoid:
                    return CreateTrapezoid(trapezoid);

                case IZ z:
                    return CreateZ(z);

                default: throw new ArgumentNullException(nameof(profile));
            }
        }

        internal static IPerimeter CreatePerimeter(IProfile profile, int divisions)
        {
            switch (profile)
            {
                case IAngle angle:
                    return CreateAngle(angle);

                case IC c:
                    return CreateC(c);

                case IChannel channel:
                    return CreateChannel(channel);

                case ICircularHollow circularHollow:
                    return CreateCircularHollow(circularHollow, divisions);

                case ICircle circle:
                    return CreateCircle(circle, divisions);

                case ICruciform cruciform:
                    return CreateCruciform(cruciform);

                case ICustomI customI:
                    return CreateCustomI(customI);

                case IEllipseHollow ellipseHollow:
                    return CreateEllipseHollow(ellipseHollow, divisions);

                case IEllipse ellipse:
                    return CreateEllipse(ellipse, divisions);

                case IIParallelFlange parallelFlange:
                    return CreateParallelFlange(parallelFlange, divisions);

                case II i:
                    return CreateI(i);

                case IRectangularHollow rectangularHollow:
                    return CreateRectangularHollow(rectangularHollow);

                case IRoundedRectangularHollow roundedRectangularHollow:
                    return CreateRoundedRectangularHollow(roundedRectangularHollow, divisions);

                case IRoundedRectangle roundedRectangle:
                    return CreateRoundedRectangle(roundedRectangle, divisions);

                case IRectangle rectangle:
                    return CreateRectangle(rectangle);

                case ITee tee:
                    return CreateTee(tee);

                case ITrapezoid trapezoid:
                    return CreateTrapezoid(trapezoid);

                case IZ z:
                    return CreateZ(z);

                default: throw new ArgumentNullException(nameof(profile));
            }
        }

        internal static (IPerimeter, IPerimeter) CreateBackToBackPerimeters<T>(T profile)
            where T : IProfile, IBackToBack
        {
            switch (profile)
            {
                case IDoubleAngle doubleAngle:
                    return CreateDoubleAngle(doubleAngle);

                case IDoubleChannel doubleChannel:
                    return CreateDoubleChannel(doubleChannel);

                default: throw new ArgumentNullException(nameof(profile));
            }
        }
    }
}
