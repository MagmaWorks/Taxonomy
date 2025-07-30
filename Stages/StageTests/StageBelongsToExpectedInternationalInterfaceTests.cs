using MagmaWorks.Taxonomy.Stages;
using MagmaWorks.Taxonomy.Stages.Denmark;
using MagmaWorks.Taxonomy.Stages.Germany;
using MagmaWorks.Taxonomy.Stages.Italy;
using MagmaWorks.Taxonomy.Stages.UK;
using MagmaWorks.Taxonomy.Stages.UK.RIBA2007;

namespace StageTests
{
    public class StageBelongsToExpectedInternationalInterfaceTests
    {
        [Theory]
        [InlineData(typeof(Idea))]
        [InlineData(typeof(Brief))]
        [InlineData(typeof(RIBAStage0))]
        [InlineData(typeof(RIBAStage1))]
        [InlineData(typeof(RIBAStageA))]
        [InlineData(typeof(RIBAStageB))]
        [InlineData(typeof(LP1))]
        [InlineData(typeof(LP2))]
        [InlineData(typeof(Byggeprogram))]
        public void IsPredesign(Type type)
        {
            Assert.True(typeof(IPredesign).IsAssignableFrom(type));
        }

        [Theory]
        [InlineData(typeof(Idea))]
        [InlineData(typeof(RIBAStage0))]
        [InlineData(typeof(LP1))]
        [InlineData(typeof(Byggeprogram))]
        public void IsIdea(Type type)
        {
            Assert.True(typeof(IIdea).IsAssignableFrom(type));
        }

        [Theory]
        [InlineData(typeof(Brief))]
        [InlineData(typeof(RIBAStage1))]
        [InlineData(typeof(LP2))]
        public void IsBrief(Type type)
        {
            Assert.True(typeof(IBrief).IsAssignableFrom(type));
        }

        [Theory]
        [InlineData(typeof(Competition))]
        public void IsCompetition(Type type)
        {
            Assert.True(typeof(ICompetition).IsAssignableFrom(type));
        }

        [Theory]
        [InlineData(typeof(ConceptDesign))]
        [InlineData(typeof(RIBAStage2))]
        [InlineData(typeof(RIBAStageC))]
        [InlineData(typeof(LP3))]
        [InlineData(typeof(PFTE))]
        [InlineData(typeof(Dispositionsforslag))]
        public void IsConcept(Type type)
        {
            Assert.True(typeof(IConceptualDesign).IsAssignableFrom(type));
        }

        [Theory]
        [InlineData(typeof(SchematicDesign))]
        [InlineData(typeof(RIBAStage3))]
        [InlineData(typeof(RIBAStageD))]
        [InlineData(typeof(LP4))]
        [InlineData(typeof(DD))]
        [InlineData(typeof(Projektforslag))]
        public void IsSchematic(Type type)
        {
            Assert.True(typeof(ISchematicDesign).IsAssignableFrom(type));
        }

        [Theory]
        [InlineData(typeof(DetailedDesign))]
        [InlineData(typeof(RIBAStage4))]
        [InlineData(typeof(RIBAStageE))]
        [InlineData(typeof(RIBAStageF))]
        [InlineData(typeof(RIBAStageG))]
        [InlineData(typeof(RIBAStageH))]
        [InlineData(typeof(LP5))]
        [InlineData(typeof(LP6))]
        [InlineData(typeof(LP7))]
        [InlineData(typeof(EXE))]
        [InlineData(typeof(Myndighedsprojekt))]
        [InlineData(typeof(Hovedprojekt))]
        public void IsDetailedDesign(Type type)
        {
            Assert.True(typeof(IDetailedDesign).IsAssignableFrom(type));
        }

        [Theory]
        [InlineData(typeof(Construction))]
        [InlineData(typeof(RIBAStage5))]
        [InlineData(typeof(RIBAStageJ))]
        [InlineData(typeof(RIBAStageK))]
        [InlineData(typeof(LP8))]
        [InlineData(typeof(DL))]
        [InlineData(typeof(Projektopfoelgning))]
        [InlineData(typeof(Udfoerelse))]
        public void IsConstruction(Type type)
        {
            Assert.True(typeof(IConstruction).IsAssignableFrom(type));
        }

        [Theory]
        [InlineData(typeof(Handover))]
        [InlineData(typeof(RIBAStage6))]
        [InlineData(typeof(LP9))]
        [InlineData(typeof(Collaudo))]
        public void IsHandover(Type type)
        {
            Assert.True(typeof(IHandover).IsAssignableFrom(type));
        }

        [Theory]
        [InlineData(typeof(InUse))]
        [InlineData(typeof(RIBAStage7))]
        [InlineData(typeof(RIBAStageL))]
        public void IsInUse(Type type)
        {
            Assert.True(typeof(IInUse).IsAssignableFrom(type));
        }

        [Theory]
        [InlineData(typeof(EndOfLife))]
        public void IsEndOfLife(Type type)
        {
            Assert.True(typeof(IEndOfLife).IsAssignableFrom(type));
        }
    }
}
