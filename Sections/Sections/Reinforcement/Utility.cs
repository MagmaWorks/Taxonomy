using System;
using System.Collections.Generic;
using MagmaWorks.Geometry;
using OasysUnits;
using OasysUnits.Units;

namespace MagmaWorks.Taxonomy.Sections.Reinforcement
{
    internal static class Utility
    {
        internal static ILongitudinalReinforcement CreateRebar(IRebar rebar, ILocalPoint2d position)
        {
            return new LongitudinalReinforcement(rebar, position);
        }

        internal static List<ILongitudinalReinforcement> CreateRebars(IRebar rebar, IList<ILocalPoint2d> positions)
        {
            var rebars = new List<ILongitudinalReinforcement>();
            foreach (ILocalPoint2d position in positions)
            {
                rebars.Add(CreateRebar(rebar, position));
            }

            return rebars;
        }

        internal static List<ILocalPoint2d> PositionsBySpacing(ILocalPoint2d start, ILocalPoint2d end, Length spacing, bool includeStartAndEnd = true)
        {
            LengthUnit unit = start.Y.Unit;
            double area = Math.Pow(start.Y.As(unit) - end.Y.As(unit), 2) + Math.Pow(start.Z.As(unit) - end.Z.As(unit), 2);
            var distance = Math.Sqrt(area);
            int count = 1 + (int)Math.Ceiling(distance / spacing.As(unit));
            return PositionsByCount(start, end, count, includeStartAndEnd);
        }

        internal static List<ILocalPoint2d> PositionsByCount(ILocalPoint2d start, ILocalPoint2d end, int count, bool includeStartAndEnd = true)
        {
            var positions = new List<ILocalPoint2d>();
            if (includeStartAndEnd)
            {
                positions.Add(start);
            }

            Length deltaY = end.Y - start.Y;
            Length deltaZ = end.Z - start.Z;
            for (int i = 1; i < count - 1; i++)
            {
                double factor = i / (double)(count - 1);
                positions.Add(new LocalPoint2d(
                    start.Y + deltaY * factor,
                    start.Z + deltaZ * factor));
            }

            if (includeStartAndEnd)
            {
                positions.Add(end);
            }

            return positions;
        }
    }
}
