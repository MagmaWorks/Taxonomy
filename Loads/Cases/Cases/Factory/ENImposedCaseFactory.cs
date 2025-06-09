using System.Collections.Generic;
using System.Linq;
using MagmaWorks.Taxonomy.Loads.Cases.EN;
using MagmaWorks.Taxonomy.Standards.Eurocode;

namespace MagmaWorks.Taxonomy.Loads.Cases
{
    public static partial class ENLoadCaseFactory
    {
        public static VariableCase CreateImposed(ImposedLoadCategory category, NationalAnnex nationalAnnex)
        {
            TableA1_1Properties factors = new ENTableA1_1Imposed().GetProperties(category, nationalAnnex);
            return new VariableCase()
            {
                CombinationFactor = factors.Phi_0,
                FrequentFactor = factors.Phi_1,
                QuasiPermanentFactor = factors.Phi_2,
                Name = $"Live loads Category {category.ToString().Last()}",
                Nickname = $"Q",
            };
        }

        public static VariableCase CreateImposed(IList<ILoad> loads, ImposedLoadCategory category, NationalAnnex nationalAnnex)
        {
            VariableCase loadCase = CreateImposed(category, nationalAnnex);
            loadCase.Loads = loads;
            return loadCase;
        }
    }
}
