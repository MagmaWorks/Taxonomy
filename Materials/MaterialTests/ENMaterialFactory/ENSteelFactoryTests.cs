namespace MaterialTests.StandardMaterials
{
    public class EnSteelFactoryTests
    {
        [Fact]
        public void CreateStandardS355ConcreteMaterialTests()
        {
            // Assemble
            NationalAnnex nationalAnnex = NationalAnnex.RecommendedValues;
            EnSteelGrade grade = EnSteelGrade.S355;

            // Act
            IEnSteelMaterial material = new EnSteelMaterial(grade, nationalAnnex);

            // Assert
            Assert.Equal(MaterialType.Steel, material.Type);
            Assert.Equal(StandardBody.EN, material.Standard.Body);
            Assert.Equal(
                "EN 1993-1-1: Eurocode 3: Design of Steel Structures - Part 1-1: General rules and rules for buildings",
                material.Standard.Title);
            Assert.Equal(EnSteelGrade.S355, material.Grade);
        }

        [Theory]
        [MemberData(nameof(AllEnTable3_1SteelMaterials))]
        public void CreateLinearElasticTests(EnSteelMaterial material)
        {
            // Assemble
            string materialGrade = GetGradeName(material);

            // Act
            ILinearElasticMaterial analysisMaterial = EnSteelFactory.CreateLinearElastic(material);

            // Assert
            double expectedStrength = Table3_1[materialGrade].fy40;
            Assert.Equal(expectedStrength, analysisMaterial.Strength.Megapascals, 12);

            double expectedElasticModulus = 210;
            Assert.Equal(expectedElasticModulus, analysisMaterial.ElasticModulus.Gigapascals, 12);

            Assert.Equal(MaterialType.Steel, analysisMaterial.Type);
        }

        [Theory]
        [MemberData(nameof(AllEnTable3_1SteelMaterials))]
        public void CreateLinearElasticThickPlatedTests(EnSteelMaterial material)
        {
            // Assemble
            string materialGrade = GetGradeName(material);
            Length thickness = new Length(60, LengthUnit.Millimeter);

            // Act
            ILinearElasticMaterial analysisMaterial = EnSteelFactory.CreateLinearElastic(material, thickness);

            // Assert
            double expectedStrength = Table3_1[materialGrade].fy80;
            Assert.Equal(expectedStrength, analysisMaterial.Strength.Megapascals, 12);

            double expectedElasticModulus = 210;
            Assert.Equal(expectedElasticModulus, analysisMaterial.ElasticModulus.Gigapascals, 12);

            Assert.Equal(MaterialType.Steel, analysisMaterial.Type);
        }

        [Theory]
        [MemberData(nameof(AllEnTable3_1SteelMaterials))]
        public void CreateBiLinearTests(EnSteelMaterial material)
        {
            // Assemble
            string materialGrade = GetGradeName(material);

            // Act
            IBiLinearMaterial analysisMaterial = EnSteelFactory.CreateBiLinear(material);

            // Assert
            double expectedYieldStrength = Table3_1[materialGrade].fy40;
            Assert.Equal(expectedYieldStrength, analysisMaterial.YieldStrength.Megapascals, 12);

            double expectedUltimateStrength = Table3_1[materialGrade].fu40;
            Assert.Equal(expectedUltimateStrength, analysisMaterial.UltimateStrength.Megapascals, 12);

            double expectedElasticModulus = 210;
            Assert.Equal(expectedElasticModulus, analysisMaterial.ElasticModulus.Gigapascals, 12);

            Assert.Equal(MaterialType.Steel, analysisMaterial.Type);
        }

        [Theory]
        [MemberData(nameof(AllEnTable3_1SteelMaterials))]
        public void CreateBiLinearThickPlatedTests(EnSteelMaterial material)
        {
            // Assemble
            string materialGrade = GetGradeName(material);
            Length thickness = new Length(60, LengthUnit.Millimeter);

            // Act
            if (material.Specification.HollowSection != null && (bool)material.Specification.HollowSection && material.Specification.DeliveryCondition == EnSteelDeliveryCondition.M)
            {
                Assert.Throws<ArgumentException>(() => EnSteelFactory.CreateBiLinear(material, thickness));
                return;
            }

            IBiLinearMaterial analysisMaterial = EnSteelFactory.CreateBiLinear(material, thickness);

            // Assert
            double expectedYieldStrength = Table3_1[materialGrade].fy80;
            Assert.Equal(expectedYieldStrength, analysisMaterial.YieldStrength.Megapascals, 12);

            double expectedUltimateStrength = Table3_1[materialGrade].fu80;
            Assert.Equal(expectedUltimateStrength, analysisMaterial.UltimateStrength.Megapascals, 12);

            double expectedElasticModulus = 210;
            Assert.Equal(expectedElasticModulus, analysisMaterial.ElasticModulus.Gigapascals, 12);

            Assert.Equal(MaterialType.Steel, analysisMaterial.Type);
        }

        [Fact]
        public void CreateLinearElasticThrowsExpectionForTooThickPlateTests()
        {
            // Assemble
            var material = new EnSteelMaterial(EnSteelGrade.S235, NationalAnnex.RecommendedValues);
            Length thickness = new Length(81, LengthUnit.Millimeter);

            // Act
            // Assert
            Assert.Throws<ArgumentException>(() => EnSteelFactory.CreateLinearElastic(material, thickness));
        }

        [Theory]
        [InlineData(EnSteelGrade.S275)]
        [InlineData(EnSteelGrade.S355)]
        [InlineData(EnSteelGrade.S420)]
        [InlineData(EnSteelGrade.S460)]
        public void CreateBiLinearThrowsExpectionForSomeGradesTests(EnSteelGrade grade)
        {
            // Assemble
            var material = new EnSteelMaterial(grade, NationalAnnex.RecommendedValues);
            material.Specification.DeliveryCondition = EnSteelDeliveryCondition.M;
            material.Specification.HollowSection = true;
            Length thickness = new Length(60, LengthUnit.Millimeter);

            // Act
            // Assert
            Assert.Throws<ArgumentException>(() => EnSteelFactory.CreateBiLinear(material, thickness));
        }

        public static IEnumerable<object[]> AllEnTable3_1SteelMaterials()
        {
            yield return new object[] { CreateMaterial("S235") };
            yield return new object[] { CreateMaterial("S275") };
            yield return new object[] { CreateMaterial("S355") };
            yield return new object[] { CreateMaterial("S450") };
            yield return new object[] { CreateMaterial("S275N") };
            yield return new object[] { CreateMaterial("S355 NL") };
            yield return new object[] { CreateMaterial("S420 N") };
            yield return new object[] { CreateMaterial("S460 NL") };
            yield return new object[] { CreateMaterial("S275 M") };
            yield return new object[] { CreateMaterial("S355 ML") };
            yield return new object[] { CreateMaterial("S420 M") };
            yield return new object[] { CreateMaterial("S460 ML") };
            yield return new object[] { CreateMaterial("S235 W") };
            yield return new object[] { CreateMaterial("S355 W") };
            yield return new object[] { CreateMaterial("S460 Q") };
            yield return new object[] { CreateMaterial("S235H") };
            yield return new object[] { CreateMaterial("S275H") };
            yield return new object[] { CreateMaterial("S355H") };
            yield return new object[] { CreateMaterial("S275NH") };
            yield return new object[] { CreateMaterial("S355NHL") };
            yield return new object[] { CreateMaterial("S420NH") };
            yield return new object[] { CreateMaterial("S460NHL") };
            yield return new object[] { CreateMaterial("S275MH") };
            yield return new object[] { CreateMaterial("S355MHL") };
            yield return new object[] { CreateMaterial("S420MH") };
            yield return new object[] { CreateMaterial("S460MHL") };
        }

        private static string GetGradeName(IEnSteelMaterial material)
        {
            string materialGrade = $"{material.Grade}{material.Specification.DeliveryCondition}";
            return materialGrade.Replace("AR", string.Empty) + ((material.Specification.HollowSection != null && (bool)material.Specification.HollowSection) ? "H" : string.Empty);
        }

        private static readonly Dictionary<string, (double fy40, double fu40, double fy80, double fu80)> Table3_1 = new()
        {
            { "S235", (235, 360, 215, 360) },
            { "S275", (275, 430, 255, 410) },
            { "S355", (355, 490, 335, 470) },
            { "S450", (440, 550, 410, 550) },

            { "S275N", (275, 390, 255, 370) },
            { "S355N", (355, 490, 335, 470) },
            { "S420N", (420, 520, 390, 520) },
            { "S460N", (460, 540, 430, 540) },

            { "S275M", (275, 370, 255, 360) },
            { "S355M", (355, 470, 335, 450) },
            { "S420M", (420, 520, 390, 500) },
            { "S460M", (460, 540, 430, 530) },

            { "S235W", (235, 360, 215, 340) },
            { "S355W", (355, 490, 335, 490) },

            { "S460Q", (460, 570, 440, 550) },

            { "S235H", (235, 360, 215, 340) },
            { "S275H", (275, 430, 255, 410) },
            { "S355H", (355, 510, 335, 490) },

            { "S275NH", (275, 390, 255, 370) },
            { "S355NH", (355, 490, 335, 470) },
            { "S420NH", (420, 540, 390, 520) },
            { "S460NH", (460, 560, 430, 550) },

            { "S275MH", (275, 360, 0, 0) },
            { "S355MH", (355, 470, 0, 0) },
            { "S420MH", (420, 500, 0, 0) },
            { "S460MH", (460, 530, 0, 0) },
        };

        private static EnSteelMaterial CreateMaterial(string s)
        {
            EnSteelMaterial.TryCreateFromDesignition(s, NationalAnnex.RecommendedValues, out EnSteelMaterial material);
            return material;
        }
    }
}
