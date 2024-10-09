using System.Collections.Generic;
using MagmaWorks.Taxonomy.Loads.Cases.EN;
using MagmaWorks.Taxonomy.Standards.Eurocode;

namespace MagmaWorks.Taxonomy.Loads.Cases
{
    public static partial class ENLoadCaseFactory
    {
        public static VariableCase CreateThermal(NationalAnnex nationalAnnex)
        {
            TableA1_1Properties factors = new ENTableA1_1Thermal().GetProperties(nationalAnnex);
            return new VariableCase()
            {
                Characteristic = factors.Phi_0,
                Frequent = factors.Phi_1,
                QuasiPermanent = factors.Phi_2,
                Name = $"Thermal loads",
                Nickname = "T",
            };
        }

        public static VariableCase CreateThermal(IList<ILoad> loads, NationalAnnex nationalAnnex)
        {
            VariableCase loadCase = CreateThermal(nationalAnnex);
            loadCase.Loads = loads;
            return loadCase;
        }
    }
}
