using MagmaWorks.Taxonomy.Materials;
using MagmaWorks.Taxonomy.Standards;
using MagmaWorks.Taxonomy.Standards.Eurocode;
using OasysUnits;
using OasysUnits.Units;

namespace MaterialTests
{
    public class ENSteelFactoryTests
    {
        [Fact]
        public void CreateStandardS355ConcreteMaterialTests()
        {
            // Assemble
            NationalAnnex nationalAnnex = NationalAnnex.RecommendedValues;
            ENSteelGrade grade = ENSteelGrade.S355;

            // Act
            IStandardMaterial material = ENSteelFactory.CreateStandardMaterial(grade, nationalAnnex);

            // Assert
            Assert.Equal(MaterialType.Steel, material.Type);
            Assert.Equal(StandardBody.EN, material.Standard.Body);
            Assert.Equal(Eurocode.EN1993, material.Standard.Code);
            Assert.Equal(
                "EN 1993-1-1: Eurocode 3: Design of Steel Structures - Part 1-1: General rules and rules for buildings",
                material.Standard.Title);
            Assert.Equal(ENSteelGrade.S355, material.Grade);
        }

        [Theory]
        [MemberData(nameof(EnumValues))]
        public void CreateLinearElasticTests(ENSteelGrade grade)
        {
            // Assemble
            // Act
            ILinearElasticMaterial material = ENSteelFactory.CreateLinearElastic(grade);

            // Assert
            double expectedStrength = Table3_1[grade].fy40;
            Assert.Equal(expectedStrength, material.Strength.Megapascals, 12);

            double expectedElasticModulus = 210;
            Assert.Equal(expectedElasticModulus, material.ElasticModulus.Gigapascals, 12);

            Assert.Equal(MaterialType.Steel, material.Type);
        }

        [Theory]
        [MemberData(nameof(EnumValues))]
        public void CreateLinearElasticThickPlatedTests(ENSteelGrade grade)
        {
            // Assemble
            Length thickness = new Length(60, LengthUnit.Millimeter);

            // Act
            ILinearElasticMaterial material = ENSteelFactory.CreateLinearElastic(grade, thickness);

            // Assert
            double expectedStrength = Table3_1[grade].fy80;
            Assert.Equal(expectedStrength, material.Strength.Megapascals, 12);

            double expectedElasticModulus = 210;
            Assert.Equal(expectedElasticModulus, material.ElasticModulus.Gigapascals, 12);

            Assert.Equal(MaterialType.Steel, material.Type);
        }

        [Theory]
        [MemberData(nameof(EnumValues))]
        public void CreateBiLinearTests(ENSteelGrade grade)
        {
            // Assemble
            // Act
            IBiLinearMaterial material = ENSteelFactory.CreateBiLinear(grade);

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
        public void CreateBiLinearThickPlatedTests(ENSteelGrade grade)
        {
            if ((int)grade > 21)
            {
                CreateBiLinearThrowsExpectionForSomeGradesTests(grade);
                return;
            }

            // Assemble
            Length thickness = new Length(60, LengthUnit.Millimeter);

            // Act
            IBiLinearMaterial material = ENSteelFactory.CreateBiLinear(grade, thickness);

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
            ENSteelGrade grade = ENSteelGrade.S235;

            // Act
            // Assert
            Assert.Throws<ArgumentException>(() => ENSteelFactory.CreateLinearElastic(grade, thickness));
        }

        [Theory]
        [InlineData(ENSteelGrade.S275MH)]
        [InlineData(ENSteelGrade.S355MH)]
        [InlineData(ENSteelGrade.S420MH)]
        [InlineData(ENSteelGrade.S460MH)]
        public void CreateBiLinearThrowsExpectionForSomeGradesTests(ENSteelGrade grade)
        {
            // Assemble
            Length thickness = new Length(60, LengthUnit.Millimeter);

            // Act
            // Assert
            Assert.Throws<ArgumentException>(() => ENSteelFactory.CreateBiLinear(grade, thickness));
        }

        public static IEnumerable<object[]> EnumValues()
        {
            foreach (var enumValue in Enum.GetValues(typeof(ENSteelGrade)))
            {
                yield return new object[] { enumValue };
            }
        }

        private static readonly Dictionary<ENSteelGrade, (double fy40, double fu40, double fy80, double fu80)> Table3_1 = new()
        {
            { ENSteelGrade.S235, (235, 360, 215, 360) },
            { ENSteelGrade.S275, (275, 430, 255, 410) },
            { ENSteelGrade.S355, (355, 490, 335, 470) },
            { ENSteelGrade.S450, (440, 550, 410, 550) },

            { ENSteelGrade.S275N, (275, 390, 255, 370) },
            { ENSteelGrade.S355N, (355, 490, 335, 470) },
            { ENSteelGrade.S420N, (420, 520, 390, 520) },
            { ENSteelGrade.S460N, (460, 540, 430, 540) },

            { ENSteelGrade.S275M, (275, 370, 255, 360) },
            { ENSteelGrade.S355M, (355, 470, 335, 450) },
            { ENSteelGrade.S420M, (420, 520, 390, 500) },
            { ENSteelGrade.S460M, (460, 540, 430, 530) },

            { ENSteelGrade.S235W, (235, 360, 215, 340) },
            { ENSteelGrade.S355W, (355, 490, 335, 490) },

            { ENSteelGrade.S460Q, (460, 570, 440, 550) },

            { ENSteelGrade.S235H, (235, 360, 215, 340) },
            { ENSteelGrade.S275H, (275, 430, 255, 410) },
            { ENSteelGrade.S355H, (355, 510, 335, 490) },

            { ENSteelGrade.S275NH, (275, 390, 255, 370) },
            { ENSteelGrade.S355NH, (355, 490, 335, 470) },
            { ENSteelGrade.S420NH, (420, 540, 390, 520) },
            { ENSteelGrade.S460NH, (460, 560, 430, 550) },

            { ENSteelGrade.S275MH, (275, 360, 0, 0) },
            { ENSteelGrade.S355MH, (355, 470, 0, 0) },
            { ENSteelGrade.S420MH, (420, 500, 0, 0) },
            { ENSteelGrade.S460MH, (460, 530, 0, 0) },
        };
    }
}
