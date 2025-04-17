using System.Collections.Generic;
using System.Linq;
using MagmaWorks.Geometry;
using MagmaWorks.Taxonomy.Profiles;

namespace MagmaWorks.Taxonomy.Sections.Reinforcement
{
    public class PerimeterReinforcementLayer : IPerimeterReinforcementLayer
    {
        public IReinforcementLayout Layout { get; set; }

        public PerimeterReinforcementLayer(IRebar rebar, int numberOfRebars)
        {
            Layout = new ReinforcementLayoutByCount(rebar, numberOfRebars);
        }

        public PerimeterReinforcementLayer(IRebar rebar, Length maxSpacing)
        {
            Layout = new ReinforcementLayoutBySpacing(rebar, maxSpacing);
        }

        public ILocalPolyline2d GetPath(IProfile profile, Length offset)
        {
            offset += Layout.Rebar.Diameter / 2;
            ILocalPolyline2d perimeter;
            if (profile is ICircle circle)
            {
                int divisions = 0;
                if (Layout is IReinforcementLayoutByCount count)
                {
                    divisions = count.NumberOfBars;
                }
                else if (Layout is IReinforcementLayoutBySpacing spacing)
                {
                    Length offsetLength = (circle.Diameter - 2 * offset) * Math.PI;
                    divisions = (int)Math.Ceiling(offsetLength / spacing.MaximumSpacing);
                }

                perimeter = new Perimeter(circle, divisions).OuterEdge;
            }
            else
            {
                perimeter = new Perimeter(profile).OuterEdge;
            }

            if (perimeter.IsClockwise())
            {
                offset *= -1;
            }

            return perimeter.Offset(offset);
        }

        public IList<ILongitudinalReinforcement> GetRebars(ILocalPolyline2d path)
        {
            var rebars = new List<ILongitudinalReinforcement>();
            if (Layout is IReinforcementLayoutByCount byCount)
            {
                int residualBars = byCount.NumberOfBars - path.Points.Count + 1;
                if (residualBars <= 0)
                {
                    var pts = path.Points.ToList();
                    pts.RemoveAt(path.Points.Count - 1);
                    rebars = Utility.CreateRebars(Layout.Rebar, pts);
                    return rebars;
                }

                double[] segments = SegmentLengths(path).ToArray();
                int[] segmentIds = Enumerable.Range(0, segments.Length).ToArray();
                Array.Sort(segments, segmentIds);
                Array.Reverse(segments);
                Array.Reverse(segmentIds);
                int[] segmentDivisions = Enumerable.Repeat(1, segments.Length).ToArray();
                int s = 0;
                while (residualBars > 0)
                {
                    if (s == segments.Length - 1)
                    {
                        segmentDivisions[s]++;
                        residualBars--;
                        s = 0;
                        continue;
                    }

                    segmentDivisions[s]++;
                    residualBars--;
                    if (segments[s + 1] / segmentDivisions[s + 1] > segments[s] / segmentDivisions[s])
                    {
                        s++;
                    }
                }

                Array.Sort(segmentIds, segmentDivisions);
                for (int i = 0; i < path.Points.Count - 1; i++)
                {
                    rebars.Add(Utility.CreateRebar(Layout.Rebar, path.Points[i]));
                    int segmentBarCount = segmentDivisions[i] + 1;
                    rebars.AddRange(Utility.CreateRebars(Layout.Rebar,
                        Utility.PositionsByCount(
                            path.Points[i], path.Points[i + 1], segmentBarCount, false)));
                }
            }
            else if (Layout is IReinforcementLayoutBySpacing bySpacing)
            {
                for (int i = 0; i < path.Points.Count - 1; i++)
                {
                    rebars.Add(Utility.CreateRebar(Layout.Rebar, path.Points[i]));
                    rebars.AddRange(Utility.CreateRebars(Layout.Rebar,
                        Utility.PositionsBySpacing(
                            path.Points[i], path.Points[i + 1], bySpacing.MaximumSpacing, false)));
                }
            }
            else
            {
                throw new ArgumentException($"Unknown Reinforcement Layout type: {Layout.GetType()}");
            }

            return rebars;
        }

        private static List<double> SegmentLengths(ILocalPolyline2d path)
        {
            Length length = Length.Zero;
            var segmentLengths = new List<double>();
            for (int i = 0; i < path.Points.Count - 1; i++)
            {
                Length segmentLength = SegmentLength(path.Points[i], path.Points[i + 1]);
                segmentLengths.Add(segmentLength.Millimeters);
            }

            return segmentLengths;
        }

        private static Length SegmentLength(ILocalPoint2d p1, ILocalPoint2d p2)
            => Point2d.Distance(new Point2d(p1), new Point2d(p2));
    }
}
