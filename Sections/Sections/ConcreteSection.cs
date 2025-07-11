using System.Collections.Generic;
using System.Linq;
using MagmaWorks.Geometry;
using MagmaWorks.Taxonomy.Materials;
using MagmaWorks.Taxonomy.Materials.StandardMaterials.En;
using MagmaWorks.Taxonomy.Profiles;
using MagmaWorks.Taxonomy.Sections.Exceptions;
using MagmaWorks.Taxonomy.Sections.Reinforcement;

namespace MagmaWorks.Taxonomy.Sections
{
    public class ConcreteSection : Section, IConcreteSection
    {
        public IList<ILongitudinalReinforcement> Rebars => CollectRebars();
        public ILink Link { get; set; }
        public Length Cover { get; set; } = Length.Zero;
        public IMinimumReinforcementSpacing MinimumReinforcementSpacing { get; set; } = new MinimumReinforcementSpacing();

        private List<ILongitudinalReinforcement> _rebars = new();
        private List<ILongitudinalReinforcement> _looseRebars = new();
        private List<IPerimeterReinforcementLayer> _perimeterReinforcementLayers = new();
        private List<IFaceReinforcementLayer> _sidesReinforcementLayers = new();
        private List<IFaceReinforcementLayer> _topBottomReinforcementLayers = new();

        private ConcreteSection() : base(null, null) { }

        public ConcreteSection(IProfile profile, IMaterial material) : base(profile, material)
        {
            ValidateMaterial();
        }
        public ConcreteSection(IProfile profile, IMaterial material, IRebar link) : this(profile, material, new Link(link)) { }

        public ConcreteSection(IProfile profile, IMaterial material, IRebar link, Length cover) : this(profile, material, new Link(link), cover) { }

        public ConcreteSection(IProfile profile, IMaterial material, IRebar link, Length cover, IList<ILongitudinalReinforcement> rebars)
            : this(profile, material, new Link(link), cover, rebars) { }

        public ConcreteSection(IProfile profile, IMaterial material, ILink link)
            : base(profile, material)
        {
            ValidateMaterial();
            Link = link;
        }

        public ConcreteSection(IProfile profile, IMaterial material, ILink link, Length cover)
            : base(profile, material)
        {
            ValidateMaterial();
            Link = link;
            Cover = cover;
        }

        public ConcreteSection(IProfile profile, IMaterial material, ILink link, Length cover, IList<ILongitudinalReinforcement> rebars)
            : base(profile, material)
        {
            ValidateMaterial();
            _looseRebars.AddRange(rebars);
            Link = link;
            Cover = cover;
        }

        public void ClearRebars()
        {
            _looseRebars.Clear();
            _perimeterReinforcementLayers.Clear();
            _sidesReinforcementLayers.Clear();
            _topBottomReinforcementLayers.Clear();
        }

        public void AddRebarLayer(IReinforcementLayer layer)
        {
            switch (layer)
            {
                case IPerimeterReinforcementLayer perimeter:
                    _perimeterReinforcementLayers.Add(perimeter);
                    break;

                case IFaceReinforcementLayer face:
                    ValidateProfileForFaceReinforcement();
                    switch (face.Face)
                    {
                        case SectionFace.Top:
                            _topBottomReinforcementLayers.Add(face);
                            break;

                        case SectionFace.Bottom:
                            _topBottomReinforcementLayers.Add(face);
                            break;

                        case SectionFace.Left:
                        case SectionFace.Right:
                            _sidesReinforcementLayers.Add(face);
                            break;

                        case SectionFace.Sides:
                            _sidesReinforcementLayers.Add(new FaceReinforcementLayer(face) { Face = SectionFace.Left });
                            _sidesReinforcementLayers.Add(new FaceReinforcementLayer(face) { Face = SectionFace.Right });
                            break;
                    }
                    break;
            }
        }

        private IList<ILongitudinalReinforcement> CollectRebars()
        {
            _rebars.Clear();
            _rebars.AddRange(_looseRebars);
            Length offset = Cover;
            if (Link != null)
            {
                offset += Link.Diameter;
            }

            foreach (IPerimeterReinforcementLayer layer in _perimeterReinforcementLayers)
            {
                CollectTopBottomRebars(layer, ref offset);
            }

            Length topOffset = offset;
            Length bottomOffset = offset;
            foreach (IFaceReinforcementLayer layer in _topBottomReinforcementLayers)
            {
                if (layer.Face == SectionFace.Top)
                {
                    CollectTopBottomRebars(layer, ref topOffset);
                }
                else
                {
                    CollectTopBottomRebars(layer, ref bottomOffset);
                }
            }

            Length leftOffset = offset;
            Length rightOffset = offset;
            foreach (IFaceReinforcementLayer layer in _sidesReinforcementLayers)
            {
                if (layer.Face == SectionFace.Left)
                {
                    CollectSideRebars(layer, ref leftOffset, topOffset, bottomOffset);
                }
                else
                {
                    CollectSideRebars(layer, ref rightOffset, topOffset, bottomOffset);
                }
            }

            _rebars = MoveCornerBars(_rebars);
            return _rebars;
        }

        private List<ILongitudinalReinforcement> MoveCornerBars(IList<ILongitudinalReinforcement> rebars)
        {
            if (Link == null || Link.Diameter.Value == 0)
            {
                return new List<ILongitudinalReinforcement>(rebars);
            }

            ILocalPolyline2d perimeter = new Perimeter(Profile).OuterEdge;
            Length offset = Cover + Link.Diameter;
            if (perimeter.IsClockwise())
            {
                offset *= -1;
            }

            ILocalPolyline2d innerSideOfLink = perimeter.Offset(offset);
            var movedBars = new List<ILongitudinalReinforcement>();
            for (int i = 0; i < rebars.Count; i++)
            {
                Length radius = (Link.MinimumMandrelDiameter > rebars[i].Rebar.Diameter
                    ? Link.MinimumMandrelDiameter : rebars[i].Rebar.Diameter) / 2;
                Length cornerOffset = (radius * Math.Sqrt(2) - radius + rebars[i].Rebar.Diameter / 2) / Math.Sqrt(2);
                Length rebarRadiusOffset = rebars[i].Rebar.Diameter / 2;
                if (perimeter.IsClockwise())
                {
                    cornerOffset *= -1;
                    rebarRadiusOffset *= -1;
                }

                IList<ILocalPoint2d> withCornerOffset = innerSideOfLink.Offset(cornerOffset).Points;
                IList<ILocalPoint2d> longitudinalBarCentres = innerSideOfLink.Offset(rebarRadiusOffset).Points;
                if (IsCornerPoint(rebars[i].Position, longitudinalBarCentres, out int id))
                {
                    var movedBar = new LongitudinalReinforcement(rebars[i].Rebar, withCornerOffset[id]);
                    movedBars.Add(movedBar);
                }
                else
                {
                    movedBars.Add(rebars[i]);
                }
            }

            return movedBars;
        }

        private bool IsCornerPoint(ILocalPoint2d pt, IList<ILocalPoint2d> corners, out int index, double tolerance = 1.0e-12)
        {
            for(index = 0; index < corners.Count; index++)
            {
                double distance = Math.Sqrt(
                    Math.Pow(corners[index].Y.Millimeters - pt.Y.Millimeters, 2) +
                    Math.Pow(corners[index].Z.Millimeters - pt.Z.Millimeters, 2));
                if (distance < tolerance)
                {
                    return true;
                }
            }

            return false;
        }

        private void CollectTopBottomRebars(IReinforcementLayer layer, ref Length offset)
        {
            ILocalPolyline2d path = layer.GetPath(Profile, offset);
            _rebars.AddRange(layer.GetRebars(path));
            offset += layer.Layout.Rebar.Diameter +
                MinimumReinforcementSpacing.GetMinimumReinforcementSpacing(layer.Layout.Rebar.Diameter);
        }

        private void CollectSideRebars(IReinforcementLayer layer, ref Length offset, Length endOffsetTop, Length endOffsetBottom)
        {
            ILocalPolyline2d path = layer.GetPath(Profile, offset);
            ILocalPoint2d top = path.Points.First();
            ILocalPoint2d bottom = path.Points.Last();
            if (path.Points.First().Z < path.Points.Last().Z)
            {
                bottom = path.Points.First();
                top = path.Points.Last();
            }

            if (endOffsetTop.Value != 0)
            {
                top = MoveStartPoint(top, bottom, endOffsetTop);
            }

            if (endOffsetBottom.Value != 0)
            {
                bottom = MoveStartPoint(bottom, top, endOffsetBottom);
            }

            _rebars.AddRange(layer.GetRebars(new LocalPolyline2d(new List<ILocalPoint2d>() { top, bottom })));
            offset += layer.Layout.Rebar.Diameter +
                MinimumReinforcementSpacing.GetMinimumReinforcementSpacing(layer.Layout.Rebar.Diameter);
        }

        private LocalPoint2d MoveStartPoint(ILocalPoint2d startPoint, ILocalPoint2d endPoint, Length offset)
        {
            LengthUnit u = offset.Unit;
            var direction = new Vector2d(
                new Length(startPoint.Y.As(u) - endPoint.Y.As(u), u),
                new Length(startPoint.Z.As(u) - endPoint.Z.As(u), u));
            direction = direction.Normalize();
            return new LocalPoint2d(
                startPoint.Y + direction.U.As(u) * -offset,
                startPoint.Z + direction.V.As(u) * -offset);
        }

        private void ValidateMaterial()
        {
            if (Material.Type != MaterialType.Concrete)
            {
                throw new InvalidMaterialTypeException("Material type must be Concrete");
            }

            if (Material is IEnConcreteMaterial en)
            {
                ((MinimumReinforcementSpacing)MinimumReinforcementSpacing).MaximumAggregateSize = en.MaximumAggregateSize;
                Cover = en.MinimumCover;
            }
        }

        private void ValidateProfileForFaceReinforcement()
        {
            InvalidProfileTypeException.ValidateProfileForFaceReinforcement(Profile);
        }
    }
}
