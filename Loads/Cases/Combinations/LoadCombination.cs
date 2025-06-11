using System.Collections.Generic;
using System.Linq;
using MagmaWorks.Taxonomy.Loads.Cases;

namespace MagmaWorks.Taxonomy.Loads.Combinations
{
    public abstract class LoadCombination : ILoadCombination
    {
        public string Name { get; set; } = string.Empty;
        public string Definition => GetDefinition();
        private IList<IPermanentCase> _permanentCases = new List<IPermanentCase>();
        public IList<IPermanentCase> PermanentCases => _permanentCases;
        private IList<bool> _permanentCaseIsFavourable = new List<bool>();
        public IList<bool> PermanentCaseIsFavourable => _permanentCaseIsFavourable;
        public IList<IVariableCase> LeadingVariableCases { get; set; } = new List<IVariableCase>();

        public void SetPermanentCases(IList<IPermanentCase> cases, IList<bool> isFavourable = null)
        {
            if (isFavourable == null)
            {
                isFavourable = cases.Select(x => true).ToList().ToList();
            }

            _permanentCases = cases;
            _permanentCaseIsFavourable = isFavourable;
        }

        internal abstract string GetDefinition();

        public abstract IList<ILoad> GetFactoredLoads();
    }
}
