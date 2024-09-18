using System.Collections.Generic;
using MagmaWorks.Geometry;

namespace MagmaWorks.Taxonomy.Profiles.PerimeterFactory
{
    public static partial class PerimeterFactory
    {
        public static IPerimeter CreateParallelFlange(IIParallelFlange profile, int filletDivisions)
        {
            List<ILocalPoint2d> pts = PerimeterFactoryUtility.CreateCustomIPoints(profile.Height, profile.Width, profile.Width,
                profile.FlangeThickness, profile.FlangeThickness, profile.WebThickness);
            List<ILocalPoint2d> filletCircle = PerimeterFactoryUtility.CreateEllipsePoints(
                profile.FilletRadius * 2, profile.FilletRadius * 2, filletDivisions * 4);
            List<ILocalPoint2d> filletBottomRight = filletCircle.GetRange(0, filletDivisions + 1);
            List<ILocalPoint2d> filletBottomLeft = filletCircle.GetRange(filletDivisions, filletDivisions + 1);
            List<ILocalPoint2d> filletTopLeft = filletCircle.GetRange(2 * filletDivisions, filletDivisions + 1);
            List<ILocalPoint2d> filletTopRight = filletCircle.GetRange(3 * filletDivisions, filletDivisions + 1);

            filletBottomRight.MovePoints(
                -profile.FilletRadius - profile.WebThickness / 2,
                -profile.Height / 2 + profile.FlangeThickness + profile.FilletRadius);
            filletBottomRight.Reverse();
            filletBottomLeft.MovePoints(
                profile.FilletRadius + profile.WebThickness / 2,
                -profile.Height / 2 + profile.FlangeThickness + profile.FilletRadius);
            filletBottomLeft.Reverse();
            filletTopLeft.MovePoints(
                profile.FilletRadius + profile.WebThickness / 2,
                profile.Height / 2 - profile.FlangeThickness - profile.FilletRadius);
            filletTopLeft.Reverse();
            filletTopRight.MovePoints(
                -profile.FilletRadius - profile.WebThickness / 2,
                profile.Height / 2 - profile.FlangeThickness - profile.FilletRadius);
            filletTopRight.Reverse();

            pts.RemoveAt(10);
            pts.InsertRange(10, filletTopRight);
            pts.RemoveAt(9);
            pts.InsertRange(9, filletBottomRight);
            pts.RemoveAt(4);
            pts.InsertRange(4, filletBottomLeft);
            pts.RemoveAt(3);
            pts.InsertRange(3, filletTopLeft);

            return new Perimeter(pts);
        }
    }
}
