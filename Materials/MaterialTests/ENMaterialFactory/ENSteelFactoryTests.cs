using MagmaWorks.Taxonomy.Materials;
using MagmaWorks.Taxonomy.Materials.StandardMaterials.En;
using MagmaWorks.Taxonomy.Standards;
using MagmaWorks.Taxonomy.Standards.Eurocode;
using OasysUnits;
using OasysUnits.Units;

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
            Assert.Equal(Eurocode.EN1993, material.Standard.Code);
            Assert.Equal(
                "EN 1993-1-1: Eurocode 3: Design of Steel Structures - Part 1-1: General rules and rules for buildings",
                material.Standard.Title);
            Assert.Equal(EnSteelGrade.S355, material.Grade);
        }

        [Theory]
        [MemberData(nameof(EnumValues))]
        public void CreateLinearElasticTests(EnSteelGrade grade)
        {
            // Assemble
            // Act
            ILinearElasticMaterial material = EnSteelFactory.CreateLinearElastic(grade);

            // Assert
            double expectedStrength = Table3_1[grade].fy40;
            Assert.Equal(expectedStrength, material.Strength.Megapascals, 12);

            double expectedElasticModulus = 210;
            Assert.Equal(expectedElasticModulus, material.ElasticModulus.Gigapascals, 12);

            Assert.Equal(MaterialType.Steel, material.Type);
        }

        [Theory]
        [MemberData(nameof(EnumValues))]
        public void CreateLinearElasticThickPlatedTests(EnSteelGrade grade)
        {
            // Assemble
            Length thickness = new Length(60, LengthUnit.Millimeter);

            // Act
            ILinearElasticMaterial material = EnSteelFactory.CreateLinearElastic(grade, thickness);

            // Assert
            double expectedStrength = Table3_1[grade].fy80;
            Assert.Equal(expectedStrength, material.Strength.Megapascals, 12);

            double expectedElasticModulus = 210;
            Assert.Equal(expectedElasticModulus, material.ElasticModulus.Gigapascals, 12);

            Assert.Equal(MaterialType.Steel, material.Type);
        }

        [Theory]
        [MemberData(nameof(EnumValues))]
        public void CreateBiLinearTests(EnSteelGrade grade)
        {
            // Assemble
            // Act
            IBiLinearMaterial material = EnSteelFactory.CreateBiLinear(grade);

            // Assert
            double expectedYieldStrength = Table3_1[grade].fy40;
            Assert.Equal(expectedYieldStrength, material.YieldStrength.Megapascals, 12);

            double expectedUltimateStrength = Table3_1[grade].fu40;
            Assert.Equal(expectedUltimateStrength, material.UltimateStrength.Megapascals, 12);

            double expectedElasticModulus = 210;
            Assert.Equal(expectedElasticModulus, material.ElasticModulus.Gigapascals, 12);

            Assert.Equal(MaterialType.Steel, material.Type);
        }

        [Theory]
        [MemberData(nameof(EnumValues))]
        public void CreateBiLinearThickPlatedTests(EnSteelGrade grade)
        {
            if ((int)grade > 21)
            {
                CreateBiLinearThrowsExpectionForSomeGradesTests(grade);
                return;
            }

            // Assemble
            Length thickness = new Length(60, LengthUnit.Millimeter);

            // Act
            IBiLinearMaterial material = EnSteelFactory.CreateBiLinear(grade, thickness);

            // Assert
            double expectedYieldStrength = Table3_1[grade].fy80;
            Assert.Equal(expectedYieldStrength, material.YieldStrength.Megapascals, 12);

            double expectedUltimateStrength = Table3_1[grade].fu80;
            Assert.Equal(expectedUltimateStrength, material.UltimateStrength.Megapascals, 12);

            double expectedElasticModulus = 210;
            Assert.Equal(expectedElasticModulus, material.ElasticModulus.Gigapascals, 12);

            Assert.Equal(MaterialType.Steel, material.Type);
        }

        [Fact]
        public void CreateLinearElasticThrowsExpectionForTooThickPlateTests()
        {
            // Assemble
            Length thickness = new Length(81, LengthUnit.Millimeter);
            EnSteelGrade grade = EnSteelGrade.S235;

            // Act
            // Assert
            Assert.Throws<ArgumentException>(() => EnSteelFactory.CreateLinearElastic(grade, thickness));
        }

        [Theory]
        [InlineData(EnSteelGrade.S275MH)]
        [InlineData(EnSteelGrade.S355MH)]
        [InlineData(EnSteelGrade.S420MH)]
        [InlineData(EnSteelGrade.S460MH)]
        public void CreateBiLinearThrowsExpectionForSomeGradesTests(EnSteelGrade grade)
        {
            // Assemble
            Length thickness = new Length(60, LengthUnit.Millimeter);

            // Act
            // Assert
            Assert.Throws<ArgumentException>(() => EnSteelFactory.CreateBiLinear(grade, thickness));
        }

        public static IEnumerable<object[]> EnumValues()
        {
            foreach (var enumValue in Enum.GetValues(typeof(EnSteelGrade)))
            {
                yield return new object[] { enumValue };
            }
        }

        private static readonly Dictionary<EnSteelGrade, (double fy40, double fu40, double fy80, double fu80)> Table3_1 = new()
        {
            { EnSteelGrade.S235, (235, 360, 215, 360) },
            { EnSteelGrade.S275, (275, 430, 255, 410) },
            { EnSteelGrade.S355, (355, 490, 335, 470) },
            { EnSteelGrade.S450, (440, 550, 410, 550) },

            { EnSteelGrade.S275N, (275, 390, 255, 370) },
            { EnSteelGrade.S355N, (355, 490, 335, 470) },
            { EnSteelGrade.S420N, (420, 520, 390, 520) },
            { EnSteelGrade.S460N, (460, 540, 430, 540) },

            { EnSteelGrade.S275M, (275, 370, 255, 360) },
            { EnSteelGrade.S355M, (355, 470, 335, 450) },
            { EnSteelGrade.S420M, (420, 520, 390, 500) },
            { EnSteelGrade.S460M, (460, 540, 430, 530) },

            { EnSteelGrade.S235W, (235, 360, 215, 340) },
            { EnSteelGrade.S355W, (355, 490, 335, 490) },

            { EnSteelGrade.S460Q, (460, 570, 440, 550) },

            { EnSteelGrade.S235H, (235, 360, 215, 340) },
            { EnSteelGrade.S275H, (275, 430, 255, 410) },
            { EnSteelGrade.S355H, (355, 510, 335, 490) },

            { EnSteelGrade.S275NH, (275, 390, 255, 370) },
            { EnSteelGrade.S355NH, (355, 490, 335, 470) },
            { EnSteelGrade.S420NH, (420, 540, 390, 520) },
            { EnSteelGrade.S460NH, (460, 560, 430, 550) },

            { EnSteelGrade.S275MH, (275, 360, 0, 0) },
            { EnSteelGrade.S355MH, (355, 470, 0, 0) },
            { EnSteelGrade.S420MH, (420, 500, 0, 0) },
            { EnSteelGrade.S460MH, (460, 530, 0, 0) },
        };
    }
}
