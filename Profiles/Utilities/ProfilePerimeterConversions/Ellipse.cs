﻿using MagmaWorks.Geometry;
using OasysUnits;
using System;
using System.Collections.Generic;

namespace MagmaWorks.Taxonomy.Profiles.Utilities
{
    public static class EllipseConversion
    {
        public static IPerimeter GetPerimeter<T>(this T profile) where T : IEllipse
        {
            return profile.GetPerimeter(new Length(10, OasysUnits.Units.LengthUnit.Millimeter));
        }

        public static IPerimeter GetPerimeter<T>(this T profile, Length tolerance) where T : IEllipse
        {
            Length max = profile.Height > profile.Width ? profile.Height : profile.Width;
            int divisions = (int)Math.Round(
                Math.PI * max / tolerance,
                MidpointRounding.AwayFromZero);
            return profile.GetPerimeter(divisions);
        }

        public static IPerimeter GetPerimeter<T>(this T profile, int divisions) where T : IEllipse
        {
            if (profile is IEllipseHollow hollow)
            {
                return EllipseHollowConversion.GetPerimeters(hollow);
            }

            return new Perimeter(GetPoints(profile.Height, profile.Width, divisions));
        }

        internal static List<IPoint2d> GetPoints(Length height, Length width, int divisions)
        {
            bool isVertical = height > width;
            double factorU = isVertical ? width / height : 1;
            double factorV = isVertical ? 1 : height / width;
            Length radius = (isVertical ? height : width) / 2;
            double degree = 0;
            var pts = new List<IPoint2d>();
            for (int i = 0; i < divisions + 1; i++)
            {
                degree = i * (360 / divisions);
                float radian = (float)(degree * Math.PI / 180);
                pts.Add(new Point2d(
                    factorU * radius * Math.Cos(degree),
                    factorV * radius * Math.Sin(degree))
                );
            }

            return pts;
        }
    }
}