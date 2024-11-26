using System;
using System.Collections.Generic;
using MagmaWorks.Geometry;
using MagmaWorks.Taxonomy.Profiles;
using MagmaWorks.Taxonomy.Sections.Exceptions;
using OasysUnits;

namespace MagmaWorks.Taxonomy.Sections.Reinforcement
{
    public class FaceReinforcementLayer : IFaceReinforcementLayer
    {
        public IReinforcementLayout Layout { get; set; }
        public SectionFace Face { get; set; }

        public FaceReinforcementLayer(SectionFace face, IRebar rebar, int numberOfRebars)
        {
            Layout = new ReinforcementLayoutByCount(rebar, numberOfRebars);
            Face = face;
        }

        public FaceReinforcementLayer(SectionFace face, IRebar rebar, Length maxSpacing)
        {
            Layout = new ReinforcementLayoutBySpacing(rebar, maxSpacing);
            Face = face;
        }

        public ILocalPolyline2d GetPath(IProfile profile, Length offset)
        {
            int startingPointIndex = 0;
            switch (profile)
            {
                case IAngle:
                    switch (Face)
                    {
                        case SectionFace.Left:
                            startingPointIndex = 0;
                            break;
                        case SectionFace.Top:
                            startingPointIndex = 1;
                            break;
                        case SectionFace.Right:
                            startingPointIndex = 2;
                            break;
                        case SectionFace.Bottom:
                            startingPointIndex = 5;
                            break;
                    }
                    break;

                case ICustomI:
                case II:
                    switch (Face)
                    {
                        case SectionFace.Left:
                            startingPointIndex = 9;
                            break;
                        case SectionFace.Top:
                            startingPointIndex = 0;
                            break;
                        case SectionFace.Right:
                            startingPointIndex = 3;
                            break;
                        case SectionFace.Bottom:
                            startingPointIndex = 6;
                            break;
                    }
                    break;

                case IRectangle:
                    switch (Face)
                    {
                        case SectionFace.Left:
                            startingPointIndex = 3;
                            break;
                        case SectionFace.Top:
                            startingPointIndex = 0;
                            break;
                        case SectionFace.Right:
                            startingPointIndex = 1;
                            break;
                        case SectionFace.Bottom:
                            startingPointIndex = 2;
                            break;
                    }
                    break;

                case ITee:
                    switch (Face)
                    {
                        case SectionFace.Left:
                            startingPointIndex = 5;
                            break;
                        case SectionFace.Top:
                            startingPointIndex = 0;
                            break;
                        case SectionFace.Right:
                            startingPointIndex = 3;
                            break;
                        case SectionFace.Bottom:
                            startingPointIndex = 4;
                            break;
                    }
                    break;

                case ITrapezoid:
                    switch (Face)
                    {
                        case SectionFace.Left:
                            startingPointIndex = 3;
                            break;
                        case SectionFace.Top:
                            startingPointIndex = 0;
                            break;
                        case SectionFace.Right:
                            startingPointIndex = 1;
                            break;
                        case SectionFace.Bottom:
                            startingPointIndex = 2;
                            break;
                    }
                    break;

                default:
                    throw new InvalidProfileTypeException($"Unable to create face rebar for {profile.GetType()} profile");
            }

            offset += Layout.Rebar.Diameter / 2;
            IList<ILocalPoint2d> pts = new Perimeter(profile, 0).OuterEdge.Offset(-offset).Points;
            return new LocalPolyline2d(new List<ILocalPoint2d>()
            {
                pts[startingPointIndex], pts[startingPointIndex + 1],
            });
        }

        public IList<ILongitudinalReinforcement> GetRebars(ILocalPolyline2d path)
        {
            bool includeStartAndEnd = Face == SectionFace.Top || Face == SectionFace.Bottom;

            if (Layout is IReinforcementLayoutByCount byCount)
            {
                List<ILocalPoint2d> positions = Utility.PositionsByCount(
                    path.Points[0], path.Points[1], byCount.NumberOfBars, includeStartAndEnd);
                return Utility.CreateRebars(Layout.Rebar, positions);
            }
            else if (Layout is IReinforcementLayoutBySpacing bySpacing)
            {
                List<ILocalPoint2d> positions = Utility.PositionsBySpacing(
                    path.Points[0], path.Points[1], bySpacing.MaximumSpacing, includeStartAndEnd);
                return Utility.CreateRebars(Layout.Rebar, positions);
            }
            else
            {
                throw new ArgumentException($"Unknown Reinforcement Layout type: {Layout.GetType()}");
            }
        }
    }
}
