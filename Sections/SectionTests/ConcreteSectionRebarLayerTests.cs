namespace SectionTests
{
    public class ConcreteSectionRebarLayerTests
    {
        [Fact]
        public void InitialisedConcreteSectionContainsNoBarsTest()
        {
            // Assemble
            IEnConcreteMaterial material = new EnConcreteMaterial(EnConcreteGrade.C30_37, NationalAnnex.UnitedKingdom);
            IRectangle profile = new Rectangle(new Length(50, LengthUnit.Centimeter), new Length(100, LengthUnit.Centimeter));
            IRebar link = RebarTests.CreateRebar(8);
            Length cover = new Length(20, LengthUnit.Millimeter);

            // Act
            IConcreteSection section1 = new ConcreteSection(profile, material);
            IConcreteSection section2 = new ConcreteSection(profile, material, link, cover);

            // Assert
            Assert.Empty(section1.Rebars);
            Assert.Empty(section2.Rebars);
        }

        [Fact]
        public void ClearRebarsTest()
        {
            // Assemble
            IEnConcreteMaterial material = new EnConcreteMaterial(EnConcreteGrade.C30_37, NationalAnnex.UnitedKingdom);
            IRectangle profile = new Rectangle(new Length(50, LengthUnit.Centimeter), new Length(100, LengthUnit.Centimeter));
            IList<ILongitudinalReinforcement> rebars = LongitudinalReinforcementTests.CreateLongitudinalReinforcements();
            IRebar link = RebarTests.CreateRebar(8);
            Length cover = new Length(20, LengthUnit.Millimeter);

            // Act
            var section = new ConcreteSection(profile, material, link, cover, rebars);

            // Assert
            Assert.NotEmpty(section.Rebars);

            // Act
            section.ClearRebars();

            // Assert
            Assert.Empty(section.Rebars);
        }

        [Theory]
        [InlineData(SectionFace.Top, 5,
            new double[] { -200, -100, 0, 100, 200 }, new double[] { 400, 400, 400, 400, 400 })]
        [InlineData(SectionFace.Bottom, 5,
            new double[] { 200, 100, 0, -100, -200 }, new double[] { -400, -400, -400, -400, -400 })]
        [InlineData(SectionFace.Right, 3,
            new double[] { 200, 200, 200 }, new double[] { 200, 0, -200 })]
        [InlineData(SectionFace.Left, 3,
            new double[] { -200, -200, -200 }, new double[] { 200, 0, -200 })]
        public void AddRebarLayerTest(SectionFace face, int expectedNoBars,
            double[] expectedYs, double[] expectedZs)
        {
            // Assemble
            LengthUnit u = LengthUnit.Millimeter;
            IEnConcreteMaterial material = new EnConcreteMaterial(EnConcreteGrade.C30_37, NationalAnnex.UnitedKingdom);
            IProfile profile = new Rectangle(new Length(400, u), new Length(800, u));
            Length cover = new Length(0, u);
            IRebar rebar = RebarTests.CreateRebar(0);
            int numberOfBars = 5;
            var layer = new FaceReinforcementLayer(face, rebar, numberOfBars);

            // Act
            var section = new ConcreteSection(profile, material, rebar, cover);
            section.AddRebarLayer(layer);
            IList<ILongitudinalReinforcement> rebars = section.Rebars;

            // Assert
            Assert.Equal(expectedNoBars, rebars.Count);
            for (int i = 0; i < expectedNoBars; i++)
            {
                Assert.Equal(expectedYs[i], rebars[i].Position.Y.As(u), 2);
                Assert.Equal(expectedZs[i], rebars[i].Position.Z.As(u), 2);
            }
        }

        [Fact]
        public void AddTwoBottomRebarLayersTest()
        {
            // Assemble
            LengthUnit u = LengthUnit.Millimeter;
            IEnConcreteMaterial material = new EnConcreteMaterial(EnConcreteGrade.C30_37, NationalAnnex.UnitedKingdom);
            IRectangle profile = new Rectangle(new Length(400, u), new Length(800, u));
            IRebar link = RebarTests.CreateRebar(8);
            Length cover = new Length(35, LengthUnit.Millimeter);
            var section = new ConcreteSection(profile, material, link, cover);
            IRebar rebar = RebarTests.CreateRebar(20);
            var layer1 = new FaceReinforcementLayer(SectionFace.Bottom, rebar, 3);
            var layer2 = new FaceReinforcementLayer(SectionFace.Bottom, rebar, 2);

            // Act
            section.AddRebarLayer(layer1);
            section.AddRebarLayer(layer2);

            // Assert
            Assert.Equal(5, section.Rebars.Count);
            double coverToFirstLayerCentre = 35.0 + 20 / 2;
            Assert.Equal(400 / 2 - coverToFirstLayerCentre, section.Rebars[0].Position.Y.As(u), 2);
            Assert.Equal(-800 / 2 + coverToFirstLayerCentre, section.Rebars[0].Position.Z.As(u), 2);
            Assert.Equal(0, section.Rebars[1].Position.Y.As(u), 2);
            Assert.Equal(-800 / 2 + coverToFirstLayerCentre, section.Rebars[1].Position.Z.As(u), 2);
            Assert.Equal(-400 / 2 + coverToFirstLayerCentre, section.Rebars[2].Position.Y.As(u), 2);
            Assert.Equal(-800 / 2 + coverToFirstLayerCentre, section.Rebars[2].Position.Z.As(u), 2);
            double coverToSecondLayerCentre = 35.0 + 20.0 + 25.0 + 20.0 / 2;
            Assert.Equal(400 / 2 - coverToSecondLayerCentre, section.Rebars[3].Position.Y.As(u), 2);
            Assert.Equal(-800 / 2 + coverToSecondLayerCentre, section.Rebars[3].Position.Z.As(u), 2);
            Assert.Equal(-400 / 2 + coverToSecondLayerCentre, section.Rebars[4].Position.Y.As(u), 2);
            Assert.Equal(-800 / 2 + coverToSecondLayerCentre, section.Rebars[4].Position.Z.As(u), 2);
        }

        [Fact]
        public void AddBottomTopAndSideRebarLayersTest()
        {
            // Assemble
            LengthUnit u = LengthUnit.Millimeter;
            IEnConcreteMaterial material = new EnConcreteMaterial(EnConcreteGrade.C30_37, NationalAnnex.UnitedKingdom);
            IRectangle profile = new Rectangle(new Length(400, u), new Length(800, u));
            IRebar link = RebarTests.CreateRebar(8);
            Length cover = new Length(35, LengthUnit.Millimeter);
            var section = new ConcreteSection(profile, material, link, cover);
            IRebar mainBars = RebarTests.CreateRebar(20);
            IRebar sideBars = RebarTests.CreateRebar(12);
            var bottom = new FaceReinforcementLayer(SectionFace.Bottom, mainBars, 3);
            var top = new FaceReinforcementLayer(SectionFace.Top, mainBars, 2);
            var left = new FaceReinforcementLayer(SectionFace.Left, sideBars, 4);
            var right = new FaceReinforcementLayer(SectionFace.Right, sideBars, 4);

            // Act
            section.AddRebarLayer(left);
            section.AddRebarLayer(right);
            section.AddRebarLayer(bottom);
            section.AddRebarLayer(bottom);
            section.AddRebarLayer(top);
            IList<ILongitudinalReinforcement> rebars = section.Rebars;

            // Assert
            Assert.Equal(3 * 2 + 2 + 2 + 2, rebars.Count);
            int i = 0;
            double coverToFirstLayerCentre = 35.0 + 20 / 2;
            // bottom first layer
            Assert.Equal(20, rebars[i].Rebar.Diameter.As(u), 2);
            Assert.Equal(400 / 2 - coverToFirstLayerCentre, rebars[i].Position.Y.As(u), 2);
            Assert.Equal(-800 / 2 + coverToFirstLayerCentre, rebars[i++].Position.Z.As(u), 2);
            Assert.Equal(20, rebars[i].Rebar.Diameter.As(u), 2);
            Assert.Equal(0, rebars[i].Position.Y.As(u), 2);
            Assert.Equal(-800 / 2 + coverToFirstLayerCentre, rebars[i++].Position.Z.As(u), 2);
            Assert.Equal(20, rebars[i].Rebar.Diameter.As(u), 2);
            Assert.Equal(-400 / 2 + coverToFirstLayerCentre, rebars[i].Position.Y.As(u), 2);
            Assert.Equal(-800 / 2 + coverToFirstLayerCentre, rebars[i++].Position.Z.As(u), 2);
            // bottom second layer
            double coverToSecondLayerCentre = 35.0 + 20.0 + 25.0 + 20.0 / 2;
            Assert.Equal(20, rebars[i].Rebar.Diameter.As(u), 2);
            Assert.Equal(400 / 2 - coverToSecondLayerCentre, rebars[i].Position.Y.As(u), 2);
            Assert.Equal(-800 / 2 + coverToSecondLayerCentre, rebars[i++].Position.Z.As(u), 2);
            Assert.Equal(20, rebars[i].Rebar.Diameter.As(u), 2);
            Assert.Equal(0, rebars[i].Position.Y.As(u), 2);
            Assert.Equal(-800 / 2 + coverToSecondLayerCentre, rebars[i++].Position.Z.As(u), 2);
            Assert.Equal(20, rebars[i].Rebar.Diameter.As(u), 2);
            Assert.Equal(-400 / 2 + coverToSecondLayerCentre, rebars[i].Position.Y.As(u), 2);
            Assert.Equal(-800 / 2 + coverToSecondLayerCentre, rebars[i++].Position.Z.As(u), 2);
            // top first layer
            Assert.Equal(20, rebars[i].Rebar.Diameter.As(u), 2);
            Assert.Equal(-400 / 2 + coverToFirstLayerCentre, rebars[i].Position.Y.As(u), 2);
            Assert.Equal(800 / 2 - coverToFirstLayerCentre, rebars[i++].Position.Z.As(u), 2);
            Assert.Equal(20, rebars[i].Rebar.Diameter.As(u), 2);
            Assert.Equal(400 / 2 - coverToFirstLayerCentre, rebars[i].Position.Y.As(u), 2);
            Assert.Equal(800 / 2 - coverToFirstLayerCentre, rebars[i++].Position.Z.As(u), 2);
            // left layer
            double coverToSideBars = 35.0 + 12 / 2;
            Assert.Equal(12, rebars[i].Rebar.Diameter.As(u), 2);
            Assert.Equal(-400 / 2 + coverToSideBars, rebars[i].Position.Y.As(u), 2);
            Assert.Equal(108, rebars[i++].Position.Z.As(u), 2);
            Assert.Equal(12, rebars[i].Rebar.Diameter.As(u), 2);
            Assert.Equal(-400 / 2 + coverToSideBars, rebars[i].Position.Y.As(u), 2);
            Assert.Equal(-63, rebars[i++].Position.Z.As(u), 2);
            // right layer
            Assert.Equal(12, rebars[i].Rebar.Diameter.As(u), 2);
            Assert.Equal(400 / 2 - coverToSideBars, rebars[i].Position.Y.As(u), 2);
            Assert.Equal(108, rebars[i++].Position.Z.As(u), 2);
            Assert.Equal(12, rebars[i].Rebar.Diameter.As(u), 2);
            Assert.Equal(400 / 2 - coverToSideBars, rebars[i].Position.Y.As(u), 2);
            Assert.Equal(-63, rebars[i++].Position.Z.As(u), 2);
        }
    }
}
